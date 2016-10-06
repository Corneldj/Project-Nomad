using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Public Variables
	public float speed;
	public float sprintModifier;
	public bool hasRifle;

	// Private Variables
	Animator anim;
	bool sprint;
	bool crouch;
	float currentSpeed;
	float sprintSpeed;
	float max;

	// Start funciton
	void Start () {
		// Set starting variables
		speed = 2;
		sprintModifier = 3f;
		sprintSpeed = speed * sprintModifier;
		hasRifle = false;
		currentSpeed = 0f;


		max = speed;
		// Animator
		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {		
		// move the character
		handleMovement ();

		// Set Animation Variables
		handleAnimationVariables ();

	}

	void handleAnimationVariables () {

		// Set movement
		anim.SetFloat("Move", (float) Input.GetAxis("Vertical"));
			
		// Set rifle
		anim.SetBool("Rifle",hasRifle);

		// Set sprint
		anim.SetBool("Sprinting",sprint);

		// Set crouch
		anim.SetBool("Crouching",crouch);
		// Set death

	}
	void handleMovement () {
		// Sprint
		if (Input.GetKey (KeyCode.LeftShift)) {
			max = sprintSpeed;
			sprint = true;
		} else {
			max = speed;
			sprint = false;
		}

		// Forward Movement
		if (Input.GetKey (KeyCode.W))
			moveForward ();
		else
			if (currentSpeed >= 0.1f)
				currentSpeed -= 0.1f;
	}

	// Forward
	void moveForward () {
		if (currentSpeed < max)
			currentSpeed += 0.1f;
		transform.position = Vector3.Lerp (transform.position, transform.position + transform.forward * currentSpeed, Time.deltaTime);
	}

	void handleCurrentSpeed (float incDec) {

	}
}
