using UnityEngine;
using System.Collections;

public class HeadTracking : MonoBehaviour {

	float dotDistanceInMM = 8.5f * 25.4f;//width of the wii sensor bar
	float screenHeightinMM = 20 * 25.4f;
	//float radiansPerPixel = (float)(Math.PI / 4) / 1024.0f; //45 degree field of view with a 1024x768 camera
	float movementScaling = 1.0f;

	//headposition
	float headX = 0;
	float headY = 0;
	float headDist = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
