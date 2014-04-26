using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {


	float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform && rigidbody){
			rigidbody;
			camera.orthographicSize += Input.GetAxis("Zoom") * Time.deltaTime * speed;
		}
	}
}
