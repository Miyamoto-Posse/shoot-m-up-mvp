using UnityEngine;
using System.Collections;

public class CompletePlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> (); //Allows access to the Rigidbody2D component
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// float invertMoveHorizontal = -(Input.GetAxis ("Horizontal"));
		// float invertMoveVertical = -(Input.GetAxis ("Vertical"));

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		// Vector2 invertMovement = new Vector2 (invertMoveHorizontal, invertMoveVertical);
		rb2d.AddForce ((movement * 2) * speed);
		// rb2d.AddForce (invertMovement * speed);
	}

}
