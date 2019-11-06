using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour {

	public int PlayerGotHitFlag=0;

	void OnCollisionEnter(Collision collision){
	if(collision.collider.tag=="Player"){
		PlayerGotHitFlag=1;
		}
	}

}
