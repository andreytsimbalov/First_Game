using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(Rigidbody2D))]

public class Bullet2D : MonoBehaviour {

	public float speed = 10f;
	public Rigidbody2D rb;
	public Transform firePoint;
	public Transform Player;
	public float damage = 7f;


	void Start()
	{
		Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 v2= new Vector2(mouse.x-firePoint.position.x-Player.position.x,mouse.y-firePoint.position.y-Player.position.y);
		float norm=v2.magnitude;
		v2.x=v2.x/norm;
		v2.y=v2.y/norm;
		rb.velocity = v2*speed;

		Debug.Log(mouse.x);
		Debug.Log(firePoint.position.x);
		Debug.Log(Player.position.x);

		// Debug.Log(v2.x);
		// Debug.Log(v2.y);
		// Debug.Log(mouse.x-firePoint.position.x-Player.position.x);
		// Debug.Log(mouse.y-firePoint.position.y-Player.position.y);
		// уничтожить объект по истечению указанного времени (секунд), если пуля никуда не попала
		Destroy(gameObject, 20);
	}

	private void OnTriggerEnter2D(Collider2D coll)
	{
		if(!coll.isTrigger) // чтобы пуля не реагировала на триггер
				{

					switch(coll.tag)
			{
			case "Enemy":
			EnemyBrain1 enemy = coll.GetComponent<EnemyBrain1>();
			if (enemy != null){
				enemy.TakeDamage(damage);
			}
			Destroy(gameObject);
				break;
			case "Tale":
				Destroy(gameObject);
				break;

			case "Player":

				break;
			}



	}
	}
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class EnemyBrain : MonoBehaviour {
//
// public float health = 20;
// public float armor = 2;
//
// public void TakeDamage(float damage){
// 	health-=damage*(1-armor/1000);
//
// 	if (health<=0){
// 		Die();
// 	}
// }
// void Die(){
// 	Destroy(gameObject);
// }
// }
