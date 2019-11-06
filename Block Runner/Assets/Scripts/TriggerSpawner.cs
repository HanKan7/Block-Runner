using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour {
	public GameObject spawner;
	void OnTriggerEnter(Collider player){

		if(player.GetComponent<Collider>().tag=="Player")
		{
			print("Spawning objects");
			Vector3 pos = transform.parent.position;

			Instantiate (spawner, pos, Quaternion.identity);


		//	print("POS.X="+pos.x);

			pos.z+=10f;




			Instantiate (spawner, pos, Quaternion.identity);
			pos.z+=10f;
			Instantiate (spawner, pos, Quaternion.identity);

		}
	}

}
