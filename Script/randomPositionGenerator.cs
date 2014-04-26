using UnityEngine;
using System.Collections;

public class randomPositionGenerator : MonoBehaviour
{

		public GameObject asteroid;
		private GameObject[] asteroids;
		public static float rangePos = 20;
		public static float rangeSpeed = 50;
		public static float rangeSpeedTo = 10;
		public static float minScale = 0.5f;
		public static float rangeScale = 1;
		public static Vector3 targetPoint = new Vector3 (0, 0, 0);
		public static int numOfAsteroids = 200;
		private static float phiStart = 0;
		private static float phiLength = (float)(Mathf.PI * 2);
		private static float thetaStart = 0;
		private static float thetaLength = (float)Mathf.PI;

		// Use this for initialization
		void Start ()
		{

				//		asteroids = GameObject.FindGameObjectsWithTag ("asteroids");
				//		Debug.Log ("Size array: ...." + asteroids.Length);
				//				foreach (GameObject  asteroid in asteroids) {


				for (int i=0; i<numOfAsteroids; i++) {
						GameObject abObj = (GameObject)Instantiate (asteroid);
						setupRandomVars (abObj);
				}
		}

		public static void setupRandomVars (GameObject gmObj)
		{
				//
				// Generowanie losowej pozycji
				//
				/*
						Vector3 pos = new Vector3 ((-rangePos / 2) + Random.value * rangePos, 
			                           (-rangePos / 2) + Random.value * rangePos, 
			                           (-rangePos / 2) + Random.value * rangePos
						);
*/
		
				//
				// Generowanie pozcyji na sferze
				//
				float u = Random.value;
				float v = Random.value;
		
				Vector3 pos = new Vector3 ((float)(-rangePos * Mathf.Cos (phiStart + u * phiLength) * Mathf.Sin (thetaStart + v * thetaLength)), 
		                           (rangePos * Mathf.Cos (thetaStart + v * thetaLength)), 
		                           (rangePos * Mathf.Sin (phiStart + u * phiLength) * Mathf.Sin (thetaStart + v * thetaLength))
				);
		
				//
				// Losowy wektor predkosci
				//
				Vector3 speed = new Vector3 ((-rangeSpeed / 2) + Random.value * rangeSpeed, 
		                             (-rangeSpeed / 2) + Random.value * rangeSpeed, 
		                             (-rangeSpeed / 2) + Random.value * rangeSpeed
				);
		
				//
				// Wektor predkosci na targetPoint
				//
				Vector3 speed2 = -pos + targetPoint;
				speed = speed + (speed2.normalized * rangeSpeedTo);
		
				Vector3 size = new Vector3 (minScale + Random.value * rangeScale, 
		                            minScale + Random.value * rangeScale, 
		                            minScale + Random.value * rangeScale
				);
		
				gmObj.transform.position = pos;
				gmObj.transform.localScale = size;
				gmObj.rigidbody.velocity = speed;
				gmObj.rigidbody.AddForce (speed); 
		}

		// Update is called once per frame
		void Update ()
		{
		}
}
