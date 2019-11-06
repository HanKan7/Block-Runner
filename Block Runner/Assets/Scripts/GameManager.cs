using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	//public PlayerMovement movement;
	public bool gameHasEnded=false;
	public float restartDelay=0.2f;

	public void PlayGame(){
 	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1	);
	}
	public void PlayAgain(){
		Health.health=100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
		PlayerCollision.scoreCount=0;
		Time.timeScale=1;
	}

	public void EndGame(){
		if(gameHasEnded==false){
			
			Debug.Log("Game Over");
			gameHasEnded=true;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1	);
			Health.health=100;
			//Invoke("",restartDelay); 
		}
	}

	public void Menu(){
	Health.health=100;
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
		PlayerCollision.scoreCount=0;
		Time.timeScale=1;
	}
	void Restart(){
		PlayerMovement.jumpCount=0;
		PlayerCollision.scoreCount=0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void QuitGame(){
	Debug.Log("Quit Game");
	Application.Quit();
	}
}
