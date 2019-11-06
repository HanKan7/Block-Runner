using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour {

void OnTriggerExit(Collider player){
if(player.gameObject.tag=="Player"){

Invoke("FallDown",0.15f);
}

}
	void FallDown(){
		print("Trigger Checked");
//	GetComponentInParent<Rigidbody>().useGravity=true;

Destroy(transform.parent.gameObject,0.5f);	
}
}

	
