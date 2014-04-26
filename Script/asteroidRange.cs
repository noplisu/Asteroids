using UnityEngine;
using System.Collections;

public class asteroidRange : MonoBehaviour
{

		float destroyRangePosition = 30;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (rigidbody.position.x > destroyRangePosition ||
						rigidbody.position.y > destroyRangePosition ||
						rigidbody.position.z > destroyRangePosition) {
						randomPositionGenerator.setupRandomVars (gameObject);
						return;
				}

				if (rigidbody.position.x < -destroyRangePosition ||
						rigidbody.position.y < -destroyRangePosition ||
						rigidbody.position.z < -destroyRangePosition) {
						randomPositionGenerator.setupRandomVars (gameObject);
				}

		}
}
