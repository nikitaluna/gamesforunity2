using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class RestartScript: MonoBehaviour
{
	void Update ()
	{
		if( Input.GetKeyDown(KeyCode.R) )
		{
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		}
	}
}