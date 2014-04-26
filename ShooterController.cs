using UnityEngine;
using System.Collections;

public class ShooterController : Photon.MonoBehaviour {
	
	MouseLook mouse;
	ShooterScript movement;
	public Camera myCamera;
	public GameObject ship;
	
	void Awake() {
		mouse = GetComponent<MouseLook>();
		movement = GetComponent<ShooterScript>();
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (photonView.isMine)
		{
			myCamera.enabled = true;
			movement.enabled = true;
			mouse.enabled = true;
		}
		else
		{
			myCamera.enabled = false;
			movement.enabled = false;
			mouse.enabled = false;
		}
	}
}