using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour {
	public GameObject powerup;
	public AudioClip audio;
	void OnTriggerEnter(Collider player){
	if(player.GetComponent<Collider>().tag=="Player"){
	print("Player picked up health");	
	Health.health+=15;
	AudioSource.PlayClipAtPoint(audio,transform.position);
	Destroy(powerup);
	}
	}
}
