using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class TestOscClient : MonoBehaviour {
	
	public int localPort;
	public int remotePort;
	public UDPPacketIO udpManager;
	public Osc oscManager;
	public Vector2[] ir_position = new Vector2[4];
	public Boolean[] ir_state = new bool[4];
	public Camera camera;
	
	private Boolean initialFlag = false;
	
	public Vector2 firstPoint;
	public Vector2 secondPoint;
	public Boolean cameraIsAboveScreen = false;
	
	
	public float dotDistanceInMM = 8.5f * 25.4f;//width of the wii sensor bar
	public float screenHeightinMM = 20 * 25.4f;
	public float radiansPerPixel = (float)(Math.PI / 4) / 1024.0f; //45 degree field of view with a 1024x768 camera
	public float movementScaling = 1.0f;
	
	public float cameraVerticaleAngle = 0; //begins assuming the camera is point straight forward
	public float relativeVerticalAngle = 0; //current head position view angle
	public float headX = 0;
	public float headY = 0;
	public float headDist = 2;
	
	public void WiiMoteOscMsgHandler(OscMessage oscMeg) {
		//Debug.Log (oscMeg.Address);
		ArrayList values = oscMeg.Values;
		string[] strings;
		if (!initialFlag)
			initialFlag = true;
		for (int i = 0; i < values.Count; i++) {
			
			strings = values[i].ToString().Split(':');
			
			Debug.Log (i + ":  "+ values[i]);
			
			if(int.Parse(strings[1]) == 1)
				ir_state[i] = true;
			else
				ir_state[i] = false;
			
			string[] positionStrings = strings[2].Split(',');
			
			float positionX = float.Parse(positionStrings[0]);
			
			float positionY = float.Parse(positionStrings[1]);
			
			ir_position[i] = new Vector2(positionX,positionY);
			
			WiiVRUpdate();
			
		}
	}
	
	// Use this for initialization
	void Start () {
		udpManager.init ("127.0.0.1", remotePort, localPort);
		oscManager.init (udpManager);
		
		oscManager.SetAddressHandler ("/WiiMote", WiiMoteOscMsgHandler);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
		{
			initialFlag = false;
			//zeros the head position and computes the camera tilt
			
			double angle = Math.Acos(.5 / headDist)-Math.PI / 2;//angle of head to screen
			if (!cameraIsAboveScreen)
				angle  = -angle;
			cameraVerticaleAngle = (float)((angle-relativeVerticalAngle));//absolute camera angle 
		}
		
		if (initialFlag) {
			
			//here is the projection in SetupMatrics()------------------------------------------
			float nearPlane = .05f;
			Vector3 pos = camera.transform.position;
			pos.x = headX;
			pos.y = headY;
			pos.z = headDist;
			camera.transform.position = pos;
		}
	}
	public void WiiVRUpdate()
	{
		firstPoint = new Vector2();
		secondPoint = new Vector2();
		int numvisible = 0;
		
		if (ir_state[0])
		{
			
			firstPoint.x = ir_position[0].x;
			firstPoint.y = ir_position[0].y;
			numvisible = 1;
		}
		
		if (ir_state[1])
		{
			if (numvisible == 0)
			{
				firstPoint.x = ir_position[1].x;
				firstPoint.y = ir_position[1].y;
				numvisible = 1;
			}
			else
			{
				secondPoint.x = ir_position[1].x;
				secondPoint.y = ir_position[1].y;
				
				numvisible = 2;
			}
		}
		
		if (ir_state[2])
		{
			
			if (numvisible == 0)
			{
				firstPoint.x = ir_position[2].x;
				firstPoint.y = ir_position[2].y;
				numvisible = 1;
			}
			else if(numvisible==1)
			{
				secondPoint.x = ir_position[2].x;
				secondPoint.y = ir_position[2].y;
				numvisible = 2;
			}
		}
		
		if (ir_state[3])
		{
			if(numvisible==1)
			{
				secondPoint.x = ir_position[3].x;
				secondPoint.y = ir_position[3].y;
				numvisible = 2;
			}
		}
		
		if (numvisible == 2)
		{
			
			float dx = firstPoint.x - secondPoint.x;
			float dy = firstPoint.y - secondPoint.y;
			float pointDist = (float)Math.Sqrt(dx * dx + dy * dy);
			
			float angle = radiansPerPixel * pointDist / 2;
			//in units of screen hieght since the box is a unit cube and box hieght is 1
			headDist = movementScaling * (float)((dotDistanceInMM / 2) / Math.Tan(angle)) / screenHeightinMM;
			
			
			float avgX = (firstPoint.x + secondPoint.x) / 2.0f;
			float avgY = (firstPoint.y + secondPoint.y) / 2.0f;
			
			
			//should  calaculate based on distance
			
			headX = (float)(movementScaling *  Math.Sin(radiansPerPixel * (avgX - 512)) * headDist);
			
			relativeVerticalAngle = (avgY - 384) * radiansPerPixel;//relative angle to camera axis
			
			if(cameraIsAboveScreen)
				headY = .5f+(float)(movementScaling * Math.Sin(relativeVerticalAngle + cameraVerticaleAngle)  *headDist);
			else
				headY = -.5f + (float)(movementScaling * Math.Sin(relativeVerticalAngle + cameraVerticaleAngle) * headDist);
			
		}
	}
	
	
}

