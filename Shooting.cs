using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	//empty gameObject to take the prefabe of each spell
	public GameObject fireball;
	public GameObject waterball;
	public GameObject lightball;
	public GameObject darknessball;

	//the speed of the ball
	public float speed;
	//to take the sound that will be played each time we fire
	public AudioClip ShootingSFX;

	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	//i wrote each spell shooting in if condition
		//because switch cant put this in case (Input.GetKeyDown(KeyCode.Alpha1))
		if (Input.GetKeyDown(KeyCode.Alpha1))
		    {
			//this to take the prefabe and put it in GameObject and creat redball each time i press that key
			GameObject firebullet = Instantiate(fireball, transform.position + transform.forward, transform.rotation) as GameObject;

		//this to check if there is rigidbody if there isnt make one
			if (!fireball.GetComponent<Rigidbody>()) 
		{
				fireball.AddComponent<Rigidbody>();
			
		}
		// give it force to move forward with its speed
			fireball.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
			fireball.transform.forward= fireball.transform.forward*speed;

			//give it sound and play it once i shoot
		if (ShootingSFX)
		{
				if (fireball.GetComponent<AudioSource> ()) { // the projectile has an AudioSource component
				// play the sound clip through the AudioSource component on the gameobject.
				// note: The audio will travel with the gameobject.
					fireball.GetComponent<AudioSource> ().PlayOneShot (ShootingSFX);
			} else {
				// dynamically create a new gameObject with an AudioSource
				// this automatically destroys itself once the audio is done
					AudioSource.PlayClipAtPoint (ShootingSFX, fireball.transform.position);
			}
		}

		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			//this to take the prefabe and put it in GameObject and creat redball each time i press that key
			GameObject waterbullet = Instantiate(waterball, transform.position + transform.forward, transform.rotation) as GameObject;
			
			//this to check if there is rigidbody if there isnt make one
			if (!waterball.GetComponent<Rigidbody>()) 
			{
				waterball.AddComponent<Rigidbody>();
				
			}
			// give it force to move forward with its speed
			waterball.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
			waterball.transform.forward= waterball.transform.forward*speed;

			//give it sound and play it once i shoot
			if (ShootingSFX)
			{
				if (waterball.GetComponent<AudioSource> ()) { // the projectile has an AudioSource component
					// play the sound clip through the AudioSource component on the gameobject.
					// note: The audio will travel with the gameobject.
					waterball.GetComponent<AudioSource> ().PlayOneShot (ShootingSFX);
				} else {
					// dynamically create a new gameObject with an AudioSource
					// this automatically destroys itself once the audio is done
					AudioSource.PlayClipAtPoint (ShootingSFX, waterball.transform.position);
				}
			}
			
		}

		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			//this to take the prefabe and put it in GameObject and creat redball each time i press that key
			GameObject lightbullet = Instantiate(lightball, transform.position + transform.forward, transform.rotation) as GameObject;
			
			//this to check if there is rigidbody if there isnt make one
			if (!lightball.GetComponent<Rigidbody>()) 
			{
				lightball.AddComponent<Rigidbody>();
				
			}
			// give it force to move forward with its speed
			lightball.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
			lightball.transform.forward= lightball.transform.forward*speed;

			//give it sound and play it once i shoot
			if (ShootingSFX)
			{
				if (lightball.GetComponent<AudioSource> ()) { // the projectile has an AudioSource component
					// play the sound clip through the AudioSource component on the gameobject.
					// note: The audio will travel with the gameobject.
					lightball.GetComponent<AudioSource> ().PlayOneShot (ShootingSFX);
				} else {
					// dynamically create a new gameObject with an AudioSource
					// this automatically destroys itself once the audio is done
					AudioSource.PlayClipAtPoint (ShootingSFX, lightball.transform.position);
				}
			}
			
		}
		else if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			//this to take the prefabe and put it in GameObject and creat redball each time i press that key
			GameObject darknessbullet = Instantiate(darknessball, transform.position + transform.forward, transform.rotation) as GameObject;
			
			//this to check if there is rigidbody if there isnt make one
			if (!lightball.GetComponent<Rigidbody>()) 
			{
				lightball.AddComponent<Rigidbody>();
				
			}
			// give it force to move forward with its speed
			lightball.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
			lightball.transform.forward= lightball.transform.forward*speed;

			//give it sound and play it once i shoot
			if (ShootingSFX)
			{
				if (lightball.GetComponent<AudioSource> ()) { // the projectile has an AudioSource component
					// play the sound clip through the AudioSource component on the gameobject.
					// note: The audio will travel with the gameobject.
					lightball.GetComponent<AudioSource> ().PlayOneShot (ShootingSFX);
				} else {
					// dynamically create a new gameObject with an AudioSource
					// this automatically destroys itself once the audio is done
					AudioSource.PlayClipAtPoint (ShootingSFX, lightball.transform.position);
				}
			}
			
		}

	}
}

//enum Spells {fire,water,light,darkness};
	// Use this for initialization
	//	void Start () {
	//		Spells fire = Spells.fire;
	//		Spells water = Spells.water;
	//		Spells light = Spells.light;
	//		Spells darkness = Spells.darkness;
	//	}

//switch (Spells) {
//case Spells.fire:
//	Debug.Log(Spells.fire);
//	Instantiate(bullet, transform.position + transform.forward, transform.rotation);
//	break;
//case Spells.water:
//	Debug.Log(Spells.water);
//	GameObject newwater = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
//	break;
//case Spells.light:
//	Debug.Log(Spells.light);
//	GameObject newlight = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
//	break;
//case Spells.darkness:
//	Debug.Log(Spells.darkness);
//	GameObject newdarkness = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
//	break;
//default:
//	Debug.Log("invalid key");
//	break;
//}