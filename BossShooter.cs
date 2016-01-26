using UnityEngine;
using System.Collections;

public class BossShooter : MonoBehaviour {

	private enum Attacks {ThreeLines, Fire, Summonig};
	private Attacks Atk = Attacks.ThreeLines;
	public BossShooter BS;
	public BossBehavior BB;
	//-----------------------------------
	public GameObject Fire;
	public GameObject DarkLine;
	public GameObject Line1;
	public GameObject Line2;
	public GameObject Line3;
	public GameObject Enemy;
	public GameObject Spawner1;
	public GameObject Spawner2;
	//-----------------------------------
	public float Power = 50f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameManager.GM.Paused) {
			switch (Atk){
			case Attacks.Fire:
				GameObject newBullet = Instantiate (Fire , //...
		      	gameObject.transform.position+gameObject.transform.forward,gameObject.transform.rotation) as GameObject;
				//-------------------------------------------
				if (!newBullet.GetComponent<Rigidbody>()){
					newBullet.AddComponent<Rigidbody>();
				}
				newBullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * Power, ForceMode.VelocityChange);
				//-------------------------------------------
				Atk = Attacks.Summonig;
				break;
				//-------------------------------------------
			case Attacks.ThreeLines:
				GameObject newBullet1 = Instantiate (DarkLine , //...
				Line1.transform.position+Line1.transform.forward,Line1.transform.rotation) as GameObject;
				GameObject newBullet2 = Instantiate (DarkLine , //...
				Line2.transform.position+Line2.transform.forward,Line2.transform.rotation) as GameObject;				
				GameObject newBullet3 = Instantiate (DarkLine , //...
				Line3.transform.position+Line3.transform.forward,Line3.transform.rotation) as GameObject;
				//-------------------------------------------
				if (!newBullet1.GetComponent<Rigidbody>()){
					newBullet1.AddComponent<Rigidbody>();
				}
				newBullet1.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * Power, ForceMode.VelocityChange);
				//-------------------------------------------
				if (!newBullet2.GetComponent<Rigidbody>()){
					newBullet2.AddComponent<Rigidbody>();
				}
				newBullet2.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * Power, ForceMode.VelocityChange);
				//-------------------------------------------
				if (!newBullet3.GetComponent<Rigidbody>()){
					newBullet3.AddComponent<Rigidbody>();
				}
				newBullet3.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * Power, ForceMode.VelocityChange);
				//-------------------------------------------
				Atk = Attacks.Fire;
				break;
				//-------------------------------------------
			case Attacks.Summonig:
				GameObject newEnemy = Instantiate (Enemy,//... 
				Spawner1.transform.position,Spawner1.transform.rotation) as GameObject;
				GameObject newEnemy1 = Instantiate (Enemy,//...
				Spawner2.transform.position,Spawner2.transform.rotation) as GameObject;
				//-------------------------------------------
				Atk = Attacks.ThreeLines;
				break;
				//-------------------------------------------
			}
			BS.enabled = false;
		}
	}
}
