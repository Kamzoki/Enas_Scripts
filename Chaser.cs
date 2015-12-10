using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]

public class Chaser : MonoBehaviour {
	
	public EnemyShooter ES;
	public EnemyMove EM;
	public float speed = 25.0f;
	public float minDist = 0f;
	public float midDist = 20f;
	public float maxDist = 30f;
	public Transform target;

	// Use this for initialization
	void Start () 
	{
		// if no target specified, assume the player
		if (target == null) {

			if (GameObject.FindWithTag ("Player")!=null)
			{
				target = GameObject.FindWithTag ("Player").GetComponent<Transform>();
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (target == null)
			return;

		// face the target
		transform.LookAt(target);

		//get the distance between the chaser and the target
		float distance = Vector3.Distance(transform.position,target.position);

		//so long as the chaser is farther away than the minimum distance, move towards it at rate speed.
		if (distance > maxDist) {
			EM.enabled = true;
			ES.enabled = false;
		}
		else if (distance <= maxDist && distance >= midDist) {
			EM.enabled = false;
			transform.Translate( Vector3.forward * speed * Time.deltaTime);
		}
		else if (distance <= midDist && distance >= minDist)
			ES.enabled = true;
	}

	// Set the target of the chaser
	public void SetTarget(Transform newTarget)
	{
		target = newTarget;
	}
	

}
