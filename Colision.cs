using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {
	void OnCollisionEnter() {
		Destroy(collider.gameObject);
	}
}
