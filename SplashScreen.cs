using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public GameObject cnv;

	public void onStartEnter(){
		GameObject.Destroy (gameObject.GetComponent<Canvas>());
		cnv.SetActive (true);
	}
}
