using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpace : MonoBehaviour {

public GameObject respawn;
	public int counter = 0; 

void OnTriggerEnter2D(Collider2D other){
	if (other.tag=="Player"){
		other.transform.position = respawn.transform.position;
		counter += 1;
		OnGUI();
	}

}
	void OnGUI()
	{
		//GUI.color = Color.black;
		if (counter > 0)
		{
			GUI.Label(new Rect(10, 5, 200, 20), "Ты умер, а жаль");
			//GUI.Box(new Rect(10, 60, 120, 30), "Key: " + 10);
		}
	}
}
