using UnityEngine;
using System.Collections;
// very important to impelement the UI image as variable 
using Image = UnityEngine.UI.Image;

public class HPController : MonoBehaviour {

	// make anew variable of shown image 
	Image Healthbar;
	Image Manabar;

	//this is the total amount of the bar and it can be between 1and 0 (fill and empty)
	 public float tmpHealthbar = 1f;
	 public float tmpManabar = 1f;
	// Use this for initialization
	void Start () {
		//assign the image variable to the real image on Hierarichy (by Searching the parent for it's childs image)
		Healthbar = GameObject.Find ("Main Camera").transform.FindChild ("Canvas").FindChild ("HealthBar").GetComponent<Image> (); 
		Manabar = GameObject.Find ("Main Camera").transform.FindChild ("Canvas").FindChild ("ManaBar").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		//make the amount of healthbar image go no more than it's highest value (1)
		if (tmpHealthbar > 1) {
			tmpHealthbar = 1f;
		}
		//make the amount of healthbar image go no more dowm than it's least value (0)
		else if (tmpHealthbar < 0) {
			tmpHealthbar =0f;
		}
		
		//make the amount of manabar image go no more than it's highest value (1)
		if (tmpManabar > 1) {
			tmpManabar = 1f;
		}
		//make the amount of manabar image go no more dowm than it's least value (0)
		else if (tmpManabar < 0) {
			tmpManabar =0f;
		}
		//give the variable value to the real amount of healthbar image  after change 
		Healthbar.fillAmount = tmpHealthbar;
		//give the variable value to the real amount of manabar image  after change 
		Manabar.fillAmount = tmpManabar;
	}
}
