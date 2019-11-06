using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour {
public ObstacleCollision oc;
void OnTriggerEnter(Collider box){
if(box.GetComponent<Collider>().tag=="Obstacle"){
if(oc.PlayerGotHitFlag!=1){

PlayerCollision.scoreCount++;
		//	print("Trigger");

}
}
}
	
}
