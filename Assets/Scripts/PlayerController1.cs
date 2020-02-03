using UnityEngine;

public class PlayerController1 : MonoBehaviour {

	public float speed = 5f;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}

	void Update () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		rb.MovePosition (rb.position + Vector2.right*moveX*speed*Time.deltaTime+ Vector2.up*moveY*speed*Time.deltaTime);
		// float moveY = Input.GetAxis ("Vertical");
		// rb.MovePosition (rb.position + Vector2.up*moveY*speed*Time.deltaTime);
	}
}
//
// using UnityEngine;
//
// public class PlayerController1 : MonoBehaviour {
//
//
//
//
// public float speed = 5f;
// private Rigidbody2D body;
// private Vector2 Movement;
//
// void Start () {
//         body = GetComponent<Rigidbody2D>();
//     }
//
//         void Update () {
//         float MoveX = Input.GetAxis('Horizontal');
//         float MoveY = Input.GetAxis('Vertical');
//         Movement = new Vector2(MoveX * speed, MoveY * speed);
//         if (MoveX == 1)
//             rotate(0);
//         if (MoveY == 1)
//             rotate(1);
//         if (MoveX == -1)
//             rotate(2);
//         if (MoveY == -1)
//             rotate(3);
//        }
//
// void FixedUpdate()
//     {
//         body.velocity = Movement;
//     }
//
// //0 - смотрим в право
//     //1 - смотрим в вверх
//     //2 - смотрим на лево
//     //3 - смотрим в низ
//     private void rotate(byte side)
//     {
//         if (side == 0)
//             transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y,-90);
//         if (side == 1)
//             transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, 0);
//         if (side == 2)
//             transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, 90);
//         if (side == 3)
//             transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, 180);
//     }
// 	}
