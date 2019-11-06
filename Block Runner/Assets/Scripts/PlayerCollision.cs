using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {
	public PlayerMovement movement;
	GameManager gmo;
	public static int scoreCount=0;
	public int PlayerGotHitFlag=0;
	public AudioClip audioSrc;
	Health totalHeal;
	void OnCollisionEnter(Collision collisionInfo){

	
	/*if(collisionInfo.collider.tag=="Obstacle"){
			movement.enabled=false;
			FindObjectOfType<GameManager>().EndGame();
	}*/
		
			if(collisionInfo.collider.tag=="Obstacle"){
			Health.health-=3;
			PlayerGotHitFlag=1;
			AudioSource.PlayClipAtPoint(audioSrc,transform.position);
			scoreCount=scoreCount-5;
			if(Health.health<=0){
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1	);
			Health.health=100;
			}
			//print ("scoreCount="+scoreCount);			
			}

			if(collisionInfo.collider.tag=="Platform"){
			PlayerMovement.jumpCount=0;
			//print("JC="+PlayerMovement.jumpCount);
			}
		
		}

}
