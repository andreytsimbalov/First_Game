using System.Collections;
using UnityEngine;

public class EnemyBrain1 : MonoBehaviour {

public float health = 20;
public float armor = 2;

public void TakeDamage(float damage){
	health-=damage*(1-armor/1000);

	if (health<=0){
		Die();
	}
}
void Die(){
	Destroy(gameObject);
}
}
