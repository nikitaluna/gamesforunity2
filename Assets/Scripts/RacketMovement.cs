using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour {
	[SerializeField] private Transform racketend;
	[SerializeField] private Rigidbody2D racketrigidbody;
	[SerializeField] public float racketforce;





	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			racketrigidbody.AddForceAtPosition (racketend.forward * racketforce, racketend.position);
		}

			
	}
}
