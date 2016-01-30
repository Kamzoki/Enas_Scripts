using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	//this variable to call any public variables from other code script the(HPController)script 
	public HPController ShowHealth ;

	//Private health variable
	public static int health = 2000;
	//the highest health value 
	 int tophealth = health;
	//the value of damage that is removed from health when it hit
	public int hit = 100;
	void Update () {
		
	}
	//Properties to access and validate variable
	public int MyHealth {
		
		//If reading variable then return health
		get{return health;}
		//Chang health value, now validate
		set{
			//Update health
			health = value;
			//Check if player should die
			if(health <= 0)
				Die();
			//make the health go no more than it's top value
			else if (health > tophealth ) {
				health = tophealth;
			}
		}
	}
	
	public void Die()
	{
		//remove the object after it dies
		GameObject.DestroyObject (this.gameObject);
	}
	
	public void Damage()
	{
		//subtract the damage from health value
		MyHealth -= hit;
		//subtract the damage from the healthbar image
		ShowHealth.tmpHealthbar -= 0.05f;
	}
	void OnCollisionEnter(Collision colin){
		//when the object hit something called "cube"
		if (colin.gameObject.name == "Cube(Clone)") {
			Debug.Log("git hit by Bullet !!!");
			Debug.Log("the health is : " + MyHealth);
			Damage ();
		}
	}

}