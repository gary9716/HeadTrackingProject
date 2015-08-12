using UnityEngine;
using System.Collections;
using WiimoteLib;

public class TestAccessWii : MonoBehaviour {

	private Wiimote wiimote;

	// Use this for initialization
	void Start () {
		wiimote = new Wiimote ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
