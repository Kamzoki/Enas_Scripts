using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	//Private health variable
	private int health=10;
	
	void Update () {
		
	}
	//Properties to access and validate variable
	public int MyHealth {
		
		//If reading variable then return health
		get{return health;}
		//Chang health value, now validate
		set{//Update health
		health = value;}
	}

}

