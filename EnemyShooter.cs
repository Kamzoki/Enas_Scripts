using UnityEngine;
using System.Collections;

public class EnemyShooter : MonoBehaviour {
	
	public float power = 20.0f;
	public Transform target;
	public GameObject bullet;
	public float fireRate = 1.0f;
	private float timer = 120f;
	
	// Update is called once per frame
	void Update () {
		//if timer went spent two seconds time, assigne new two seconds time.
		if (timer <= 0)
			timer = 120;
		timer--;
		shoot ();
	}
	//shooting function
	void shoot()
	{
		//Controling fire rate by timer, every two seconds
		if (timer == fireRate) {
		//create and translate bullets
		GameObject newBullet = Instantiate(bullet, gameObject.transform.position + gameObject.transform.forward,gameObject.transform.rotation) as GameObject;
		newBullet.GetComponent<Rigidbody> ().AddForce (transform.forward * power, ForceMode.VelocityChange);
		}
	}
	
}
