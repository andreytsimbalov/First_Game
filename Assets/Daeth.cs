using UnityEngine;
using System.Collections;

public class Daeth : MonoBehaviour {
public GameObject player;
public float speed = 3f;
private Rigidbody2D rb;
        void OnCollisionEnter (Collision myCollision){
                if (myCollision.gameObject == player){
                        Debug.Log("Message");
												rb.MovePosition (rb.position - Vector2.right*speed*Time.deltaTime);
                }

}
}
