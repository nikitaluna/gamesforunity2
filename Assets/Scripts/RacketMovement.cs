using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour {
	[SerializeField] private Transform racketend;
	[SerializeField] private Rigidbody2D racketrigidbody;





	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			racketrigidbody.AddForceAtPosition (Vector2.one * 100, racketend.position);
		}

			
	}
}
