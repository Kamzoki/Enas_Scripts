using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	//public variables for player behavior
	public float moveSpeed = 0.5f;
	public float gravity = 9.81f;
	//character controller object
	private CharacterController CC;
	// Use this for initialization
	void Start () {
		//Get the character controller component to the object
		CC = gameObject.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		// movement in Z direction
		Vector3 movementZ = Input.GetAxis ("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;
		// movement in X direction
		Vector3 movementX = Input.GetAxis ("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;
		// Movement variable
		Vector3 movement = transform.TransformDirection (movementX + movementZ);
		// Aplaying gravity if not standing on something
		movement.y -= gravity * Time.deltaTime;

		//actual movement
		CC.Move (movement);
	}
}
