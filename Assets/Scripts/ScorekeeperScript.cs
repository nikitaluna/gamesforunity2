using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorekeeperScript : MonoBehaviour {
	public Text scoretext;
	public int playerScore;

	public void increaseScore ()
	{
		playerScore += 1;
		scoretext.text = playerScore.ToString();

	}

		
}

