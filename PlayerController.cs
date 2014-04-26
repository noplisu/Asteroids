using UnityEngine;
using System.Collections;

public class PlayerController : Photon.MonoBehaviour {

	MouseLook mouse;
	ShipMovement movement;
	Shooter shooter;
	public Camera myCamera;

	void Awake() {
		mouse = GetComponent<MouseLook>();
		movement = GetComponent<ShipMovement>();
		shooter = GetComponent<Shooter>();
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (photonView.isMine)
		{
			//MINE: local player, simply enable the local scripts
			myCamera.enabled = true;
			movement.enabled = true;
			mouse.enabled = true;
			shooter.enabled = true;
		}
		else
		{
			myCamera.enabled = false;
			movement.enabled = false;
			mouse.enabled = false;
			shooter.enabled = false;
		}

	}
}
