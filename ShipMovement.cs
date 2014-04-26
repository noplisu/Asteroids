using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {


	public float force = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform && rigidbody){
			rigidbody.AddForce(transform.forward * Input.GetAxis("Throttle") * force);
			rigidbody.AddForce(transform.up * Input.GetAxis("Vertical") * force);
			rigidbody.AddForce(transform.right * Input.GetAxis("Horizontal") * force);
		}
	}
}
