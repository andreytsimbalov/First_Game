using System.Collections;
using UnityEngine;

public class EnemyBrain1 : MonoBehaviour
{

	public float health = 20;
	public float armor = 2;
	public float speed = 1;
	private Vector2 vectMove;

	void Start()
	{
		vectMove.x = 0;
		vectMove.y = 0;

	}
	public void TakeDamage(float damage)
	{
		health -= damage * (1 - armor / 1000);

		if (health <= 0)
		{
			Die();
		}
	}
	void Die()
	{
		Destroy(gameObject);
	}

	void Update()
	{
		//transform.Translate(Vector2.up * speed * Time.deltaTime);


	}

	private void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.isTrigger) // чтобы пуля реагировала на триггер
		{
			if (coll.tag == "bullet")
			{

				transform.Translate(vectMove * speed * Time.deltaTime);
				vectMove.x = Random.Range(-1f, 1f);
				vectMove.y = Random.Range(-1f, 1f);
			}

		}
	}

	//private void OnTriggerEnter2D(Collider2D coll)
	//{
	//	if (coll.isTrigger) // чтобы пуля реагировала на триггер
	//	{
	//		if (coll.tag == "bullet")
	//		{
	//			vectMove.x = Random.Range(-1f, 1f);
	//			vectMove.y = Random.Range(-1f, 1f);

	//		}

	//	}
	//}
}
