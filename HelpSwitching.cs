using UnityEngine;
using System.Collections;

public class HelpSwitching : MonoBehaviour {

	//these variables to call any public variables from other code scripts the(HPController & Health)scripts 
	public HPController ViewHealth ;
	public Health heal;

	//making array of partners to choose one of them to call his help
	//you can identify it's size and assign it's elemets in unity
	public string [] partners;
	private int index=0;
	//refer to the selected partner from the array
	private string selected;
	//the amount of added health when calling Clover healing help
	public int Cloverheal = 700;
	// Use this for initialization
	void Start () {
		//if the array has any element and not empty select the first partner
		if (partners.Length != 0) {
			selected = partners[index];
			Debug.Log("the selected partner is"+selected);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//when the player press (tab) select the next partner in the array
		if (Input.GetKey (KeyCode.Tab)) {
			index++;
			selected = partners[index];
			if (index >= partners.Length) {
				index=0;
			}
			Debug.Log("the selected partner is"+selected);
		}

		//when the player press () use it's partner help
		if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Mouse1)) {
			help();
		}
	}
	public void help()
	{
		//check who is the partner to do it's power
		//very case in the switch is the name for one of the partners in the array
		switch (selected) {
		case "Clover":
			Debug.Log("Healing");
			heal.MyHealth+=Cloverheal;
			ViewHealth.tmpHealthbar += ViewHealth.tmpHealthbar/3f;
			ViewHealth.tmpManabar -= ViewHealth.tmpManabar/4f;
			break;
			
		default:
			break;
		}
	}
}
