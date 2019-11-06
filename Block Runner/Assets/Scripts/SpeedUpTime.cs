using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpTime : MonoBehaviour {

	private int tempScore=10;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerCollision.scoreCount>tempScore){
		if(Time.timeScale<=1.35)	
		Time.timeScale+=0.1f;
		tempScore+=7;
		}

	}
}
