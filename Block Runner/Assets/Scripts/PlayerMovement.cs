using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce=500f;
	public float sideForce=500f;
	public float upwardForce=750f;
	public PlayerCollision collision;
	public static int jumpCount=0;
	float directionX;

	void Start(){
	//rb=FindObjectOfType<Rigidbody>();
	}
	// Update is called once per frame
	public void Jump(){
		jumpCount++;
				//print("JumpCOunt"+jumpCount+"\n");
				if(jumpCount<3)
				rb.AddForce(0f,upwardForce*Time.deltaTime,0f,ForceMode.VelocityChange);

	}
	public void Left(){

	//while(true)	
		rb.AddForce(-sideForce*Time.deltaTime,0f,0f,ForceMode.VelocityChange);

	}
	public void Right(){
		rb.AddForce(sideForce*Time.deltaTime,0f,0f,ForceMode.VelocityChange);
	}
	void Update () {
		rb.AddForce(0f,0f,forwardForce*Time.deltaTime);
		//directionX=CrossPlatformInputManager.GetAxis("Horizontal");

		//	rb.velocity=new Vector3(directionX*150,0f,0f);

		
			if(Input.GetKey("d")){
				rb.AddForce(sideForce*Time.deltaTime,0f,0f,ForceMode.VelocityChange);
			}
			if(Input.GetKey("a")){
				rb.AddForce(-sideForce*Time.deltaTime,0f,0f,ForceMode.VelocityChange);
			}
			if(Input.GetKeyDown(KeyCode.Space)){
			jumpCount++;
				//print("JumpCOunt"+jumpCount+"\n");
				if(jumpCount<3)
				rb.AddForce(0f,upwardForce*Time.deltaTime,0f,ForceMode.VelocityChange);

			}
			if(rb.position.y<-3f){

			FindObjectOfType<GameManager>().EndGame();
			//PlayerCollision.scoreCount=0;

			}
		}

}
