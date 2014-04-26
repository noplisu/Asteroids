using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {


	public GameObject bullet;
	public Transform space;
	public Camera camera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			GameObject shoot = (GameObject) Instantiate(bullet, space.position, Quaternion.identity);
			shoot.rigidbody.AddForce(camera.transform.forward * 1000);
		}
	}
}
