using UnityEngine;
using System.Collections;

public class enemyShooter : MonoBehaviour {

	public float speed = 10.0f;
	public Transform target;
	public GameObject bullet;
	//public float maxDist = 20f;
	//public float minDist = 10f;
	//public Chaser ch;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Invoke ("shoot",3*Time.deltaTime);
		/*float distance = Vector3.Distance(transform.position,target.position);

		if (distance < maxDist && distance > minDist) {
			//this.enabled = false;
			//ch.enabled =true;
			
		}
		else if(distance <= minDist){
			//ch.enabled = false;
			Invoke("shoot",3*Time.deltaTime);

			
		}
		else{
			//this.enabled = false;
			//ch.enabled = true;
		}*/
	}
	void shoot()
	{
		GameObject firebullet = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
	}
}
