
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOthers : MonoBehaviour {
	public Spawner spawner;
	public GameObject[] platform;
	//public GameObject diamonds;
	int rand;
	Vector3 lastPos;
	float size;
	public bool gameOver;

	void SpawnPlatform(){
		if (gameOver)
			return;
		//int rand = Random.Range (0, 3);

			SpawnZ (rand);
		
		//spawner.stop=true;

	}

	/*bool SpawnDiamond(){
		int rand = Random.Range (0, 4);
		if (rand < 1)
			return true;
		else
			return false;
	}*/

	public void StartSpawningPlatform(){
		InvokeRepeating ("SpawnPlatform", 0.1f, 0.2f);
	}

	// Use this for initialization
	void Start () {
	//spawner=FindObjectOfType<Spawner>();
		lastPos = platform[0].transform.position;
		size	= platform[0].transform.localScale.z;

		rand =0;
		SpawnPlatform();
		//for (int i = 0; i < 13; i++) {

		//	SpawnPlatform ();
			//print("Hello C");
			//spawner.stop=true;

		//}
		StartCoroutine(waitSpawn(spawner));
		StartCoroutine(waitSpawn(spawner));
	}

	// Update is called once per frame
	void Update () {
	//	if (GameManager.instance.gameOver == false)
		//	CancelInvoke ("SpawnPlatform");
		while(true)
		{

		int newrand = Random.Range(0,3);
		if(newrand!=rand)
		{
			rand= newrand;
			break;
		}
		}
		SpawnPlatform();
	}
		
	/*void SpawnX(){

		Vector3 pos = 	lastPos;
		pos.x 	   +=	size;  
		lastPos 	=	pos;
		Instantiate (platform[0], pos, Quaternion.identity);

		/*if (SpawnDiamond ()) {
			Instantiate (diamonds, new Vector3(pos.x, pos.y+1, pos.z), diamonds.transform.rotation);
		}*/
	//	}
	void SpawnZ(int i){

		Vector3 pos = 	lastPos;
		if(i==0)
		{
			pos.x=0;
			pos.z+=size;
		}
		else if(i==1)
		{
			pos.x=-10;
			pos.z+=size;
		}
		else if(i==2)
		{
			pos.x = 10;
			pos.z+=size;
		}  		
		lastPos 	=	pos;
			Instantiate (platform[i], pos, Quaternion.identity);

		/*if (SpawnDiamond ()) {
			Instantiate (diamonds, new Vector3(pos.x, pos.y+1, pos.z), diamonds.transform.rotation);
		}*/
	}
	IEnumerator waitSpawn(Spawner spawner){
	yield return new WaitForSeconds(4);
	//print("StartWait"+startWait);
		spawner.stop = true;
	}
}

