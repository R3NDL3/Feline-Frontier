using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

	public int walkSpeed;
	public int sprintSpeed;
	public int jumpHeight;
	public int maxJumps;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask groundLayer;
	
	private int numJumps;

	// Use this for initialization
	public void Start () {
		numJumps = 0;
	}

	// Update is called once per frame
	public void Update() {
		if (grounded())
			numJumps = 0;

		if (Input.GetKeyDown(KeyCode.Space) && canJump() && grounded()) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			numJumps++;
		}
		if (Input.GetKeyDown(KeyCode.Space) && canJump() && !grounded()) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			numJumps++;
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			if (Input.GetKey(KeyCode.LeftShift)){
				GetComponent<Rigidbody2D>().velocity = new Vector2(-sprintSpeed, GetComponent<Rigidbody2D>().velocity.y);
				//transform.Translate (-Vector2.right * -speed * Time.deltaTime);
				transform.eulerAngles = new Vector2(0,180);
			}else{
				GetComponent<Rigidbody2D>().velocity = new Vector2(-walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
				//transform.Translate (-Vector2.right * -speed * Time.deltaTime);
				transform.eulerAngles = new Vector2(0,180);
			}
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			if (Input.GetKey(KeyCode.LeftShift)){
				GetComponent<Rigidbody2D>().velocity = new Vector2(sprintSpeed, GetComponent<Rigidbody2D>().velocity.y);
				//transform.Translate (Vector2.right * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2(0,0);
			}else{
				GetComponent<Rigidbody2D>().velocity = new Vector2(walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
				//transform.Translate (Vector2.right * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2(0,0);
			}
		}
	}

	void FixedUpdate()
	{
		//A delayed update

	}

	public void OnCollisionEnter2D (Collision2D coll){
		//Colliding with other objects. Utilizes tags.
		if (coll.gameObject.tag == "trigger_hurt") {

		}
	}

	private bool grounded()
	{
		return Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, groundLayer);
	}
	private bool canJump()
	{
		return numJumps < maxJumps;
	}
}

//SWEEP TEST FOR POSSIBLE STOPPING ON A WALL
//PROBLEM: ONLY A NORMAL RIGIDBODY HAS SWEEPTEST
// Get the velocity
//Vector2 horizontalMove = GetComponent<Rigidbody2D>().velocity;
// Don't use the vertical velocity
//horizontalMove.y = 0;
// Calculate the approximate distance that will be traversed
//float distance =  horizontalMove.magnitude * Time.fixedDeltaTime;
// Normalize horizontalMove since it should be used to indicate direction
//horizontalMove.Normalize();
//RaycastHit hit;

//Check if the body's current velocity will result in a collision
//if(Rigidbody.SweepTest(horizontalMove, out hit, distance))
//{
//	// If so, stop the movement
//	GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
//}
