using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public SpawnOthers so;
	public GameObject[] obstacles;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnLeastWait;
	public float spawnMostWait;
	public int startWait;
	public bool stop;
	int randomEnemy;
	// Use this for initialization
	void Start () {

		StartCoroutine(waitSpawner());

	}
	
	// Update is called once per frame
	void Update () {
		spawnWait=Random.Range(spawnLeastWait,spawnMostWait);

	}

	IEnumerator waitSpawner(){
	yield return new WaitForSeconds(startWait);
	int count=0;
	int range = (int) Random.Range(3,10);
	//print("StartWait"+startWait);
		while (!stop){
		if(count==range)
			break;
		//randomEnemy=Random.Range(0);
		count++;
		float x = transform.position.x;
			Vector3 spawnPosition=new Vector3(Random.Range(x-3.1f,x+3.2f),1f,transform.position.z);
			Instantiate(obstacles[0],spawnPosition,gameObject.transform.rotation);
			yield return new WaitForSeconds(spawnWait);
			//print("Spawn Wait="+spawnWait);
		}		
	}
}
