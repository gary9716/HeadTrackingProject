using System;
using System.Collections.Generic;
using WiimoteLib;
using UnityEngine;

public class TestOscClient : MonoBehaviour {
	
	public int localPort;
	public int remotePort;
	public UDPPacketIO udpManager;
	public Osc oscManager;

	public void oscMsgHandler(OscMessage oscMeg) {
		Debug.Log (oscMeg.Address);
		//Debug.Log ("addr:" + oscMeg.Address);
	}

	// Use this for initialization
	void Start () {
		udpManager.init ("127.0.0.1", remotePort, localPort);
		oscManager.init (udpManager);

		oscManager.SetAllMessageHandler (oscMsgHandler);

	}

	// Update is called once per frame
	void Update () {
	
	}
}
