using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {



	public Transform firePoint;
	public GameObject bullet;
	public float offset;
	public float startShotTime;
	private float timeShot=0;
	//public Transform Player;

	void Update () {
		Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float rotateZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f,0f,rotateZ+offset);

		if (timeShot <= 0)
		{
			if (Input.GetMouseButtonDown(0))
			{
				Shoot();
				timeShot = startShotTime;
			}
		}
		else
		{
			timeShot -= Time.deltaTime; 
		}
	}

	void Shoot(){
		Instantiate(bullet, firePoint.position,firePoint.rotation);
	}

}
