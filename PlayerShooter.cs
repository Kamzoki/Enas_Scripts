using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour {

	//the four elements.
	private enum Elements {Fire, Water, Lightning, BlackMagic};
	//Default element
	private Elements element= Elements.Lightning;
	//Lightning Model prefab
	public GameObject Lightningbullet;
	public GameObject Firebullet;
	public GameObject Waterbullet;
	public GameObject BlackMagicbullet;
	//Movement power
	public float power = 10.0f;

	
	// Update is called once per frame
	void Update () {
		// these conditions to check the input (1,2,3,4) and change element type
		if (Input.GetKey (KeyCode.Alpha1))
			element = Elements.Lightning;
		else if (Input.GetKey (KeyCode.Alpha2))
			element = Elements.Fire;
		else if (Input.GetKey (KeyCode.Alpha3))
			element = Elements.Water;
		else if (Input.GetKey (KeyCode.Alpha4))
			element = Elements.BlackMagic;
		//this condition checks on the element type and fire the right prefab attached.
		switch (element) {
			//when the player choose '1' or 'lightning'
			case Elements.Lightning :
				if (Input.GetKey (KeyCode.Mouse0)) {
				if (Lightningbullet){
					GameObject newBullet = Instantiate (Lightningbullet , //...
					gameObject.transform.position+gameObject.transform.forward,gameObject.transform.rotation) as GameObject;
					
					if (!newBullet.GetComponent<Rigidbody>()){
						newBullet.AddComponent<Rigidbody>();
					}
					newBullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * power, ForceMode.VelocityChange);
				}
			}
			break;

		case Elements.Fire :
			if (Input.GetKey (KeyCode.Mouse0)) {
			if (Firebullet){
				GameObject newBullet = Instantiate (Firebullet , //...
				gameObject.transform.position+gameObject.transform.forward,gameObject.transform.rotation) as GameObject;
					
				if (!newBullet.GetComponent<Rigidbody>()){
					newBullet.AddComponent<Rigidbody>();
				}
				newBullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * power, ForceMode.VelocityChange);
				}
			}
			break;

		case Elements.Water :
			if (Input.GetKey (KeyCode.Mouse0)) {
			if (Waterbullet){
				GameObject newBullet = Instantiate (Waterbullet , //...
				gameObject.transform.position+gameObject.transform.forward,gameObject.transform.rotation) as GameObject;
					
				if (!newBullet.GetComponent<Rigidbody>()){
					newBullet.AddComponent<Rigidbody>();
				}
					newBullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * power, ForceMode.VelocityChange);
				}
			}
			break;

		case Elements.BlackMagic :
			if (Input.GetKey (KeyCode.Mouse0)) {
			if (BlackMagicbullet){
				GameObject newBullet = Instantiate (BlackMagicbullet , //...
				gameObject.transform.position+gameObject.transform.forward,gameObject.transform.rotation) as GameObject;
					
				if (!newBullet.GetComponent<Rigidbody>()){
					newBullet.AddComponent<Rigidbody>();
				}
					newBullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * power, ForceMode.VelocityChange);
				}
			}
			break;

		}
	}
}
