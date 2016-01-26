using UnityEngine;
using System.Collections;

public class BossBehavior : MonoBehaviour {

	private int wayPointId = 0; //Used for indexing the array
	public float speed = 40f;	// Boss movement speed
	public GameObject [] wayPoints; //Array of waypoints (empty game objects)
	public float movingTimer = 300f; // how much to stop at each waypoint. each 60 = 1 sec
	public BossShooter BS;
	public BossBehavior BB;

	void Movement(){
		
		if (wayPoints.Length != 0) {
			//if (Vector3.Distance(wayPoints[wayPointId].transform.position, transform.position) <=0)
				//BS.enabled = true;
		}
		// If reach the last element of array, start over.
		if (wayPointId >= wayPoints.Length) {
			wayPointId = 0;
		}
		transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPointId].transform.position, speed * Time.deltaTime);

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (movingTimer <= 0) {
			wayPointId++;
			movingTimer = 120f;
			BS.enabled = true;
		}
		else {
			movingTimer--;
			Movement();
		}
			
	}
}
