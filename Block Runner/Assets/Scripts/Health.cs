using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	public static int health=100;
	public Text healthText;

	
	// Update is called once per frame
	void Update () {
		healthText.text=health.ToString("0");
	}
}
