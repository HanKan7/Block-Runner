using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour {
	public GameObject Object;
	public Rigidbody body;
	void Start(){

	}

	void OnCollisionEnter(Collision col){
	if(col.collider.tag=="Player"){
	print("Platform collision");
	//body.useGravity=true;
	}
	}


}
