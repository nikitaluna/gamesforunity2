using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {

	public float xmin;
	public float xmax;
	public float ymin;
	public float ymax;
	public ScorekeeperScript scoreKeeper;
	public ParticleSystem Effect; 

	void OnCollisionEnter2D(Collision2D collision)
	{
		//Debug.Log("OnCollisionEnter2D");
		if (collision.gameObject.tag == "Ball") {
			Instantiate (Effect, transform.position, Quaternion.identity);
			Instantiate(gameObject, new Vector3(Random.Range(xmin,xmax), Random.Range(ymin,ymax), 0f), Quaternion.identity);
			scoreKeeper.increaseScore ();
			Destroy (gameObject);



		}
	}


}
