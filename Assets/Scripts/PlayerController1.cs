using UnityEngine;

public class PlayerController1 : MonoBehaviour {

	public float speed = 5f;
	private Rigidbody2D rb;
	private bool faceRight = true;
	private int flagHor;
	private int flagVer;
//_______________
// public float speedbullet = 10; // скорость пули
// 	public Rigidbody2D bullet; // префаб нашей пули
// 	public Transform gunPoint; // точка рождения
// 	public float fireRate = 1; // скорострельность
//
// 	public Transform zRotate; // объект для вращения по оси Z
//
// 	// ограничение вращения
// 	public float minAngle = -40;
// 	public float maxAngle = 40;
//
// 	private float curTimeout;
//
//
//
// 	void SetRotation()
// 	{
// 		Vector3 mousePosMain = Input.mousePosition;
// 		mousePosMain.z = Camera.main.transform.position.z;
// 		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePosMain);
// 		lookPos = lookPos - transform.position;
// 		float angle  = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
// 		angle = Mathf.Clamp(angle, minAngle, maxAngle);
// 		zRotate.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
// 	}
//
// 	void Fire()
// 	{
// 		curTimeout += Time.deltaTime;
// 		if(curTimeout > fireRate)
// 		{
// 			curTimeout = 0;
// 			Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody2D;
// 			clone.velocity = transform.TransformDirection(gunPoint.right * speedbullet);
// 			clone.transform.right = gunPoint.right;
// 		}
// 	}
	//-----------
	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}

	void Update () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		// if (moveX !=0){
		// 	if (moveX>0){moveX=1;}
		// 	else {moveX=-1;}
		// }
		// flagHor=0;
		// if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A)){
		// 	flagHor=1;
		// }
		//
		// if (moveY !=0){
		// 	if (moveY>0){moveY=1;}
		// 	else {moveY=-1;}
		// }
		// flagVer=0;
		// if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)){
		// 	flagVer=1;
		// }

		rb.MovePosition (rb.position +(Vector2.right*moveX*speed+ Vector2.up*moveY*speed)*Time.deltaTime);//*Time.deltaTime

		if (moveX>0 && !faceRight)
			flip();
		else if (moveX<0 && faceRight) flip();

		//_________________
		// if(Input.GetMouseButton(0))
		// {
		// 	Fire();
		// }
		// else
		// {
		// 	curTimeout = 100;
		// }
		//
		// if(zRotate) SetRotation();
		//___________________
	}

	void flip(){
		faceRight=!faceRight;
		//transform.localScale = new Vector3(transform.localScale.x*(-1),transform.localScale.y,transform.localScale.z);
		transform.Rotate(0f,180f,0f);
	}
}
