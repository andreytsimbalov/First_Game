﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpace : MonoBehaviour {

public GameObject respawn;

void OnTriggerEnter2D(Collider2D other){
	if (other.tag=="Player"){
		other.transform.position = respawn.transform.position;
	}

}
}
