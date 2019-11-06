using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	public Rigidbody rbo;
	public float travelForce=500f;


	
	// Update is called once per frame
	void FixedUpdate () {
		rbo.AddForce(0f,0f,-travelForce*Time.deltaTime);
		if(rbo.position.y<-5f){
		Destroy(gameObject);	
		}
	}
}
