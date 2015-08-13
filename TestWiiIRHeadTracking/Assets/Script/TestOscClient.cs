using System;
using System.Collections.Generic;
using WiimoteLib;
using UnityEngine;
using System.Collections;
public class TestOscClient : MonoBehaviour {
	
	public int localPort;
	public int remotePort;
	public UDPPacketIO udpManager;
	public Osc oscManager;

	public void WiiMoteOscMsgHandler(OscMessage oscMeg) {
		//Debug.Log (oscMeg.Address);
		ArrayList values = oscMeg.Values;
		for (int i = 0; i < values.Count; i++) {
			Debug.Log (i + ":" + values[i].ToString());
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
	
	}
}
