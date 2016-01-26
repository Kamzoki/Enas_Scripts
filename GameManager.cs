using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private bool pausedC = false;

	private bool paused;

	public bool Paused {
		get {
			return paused;
		}
	}

	private static GameManager gm;

	public static GameManager GM {
		get {
			if(gm == null)
				gm = GameObject.FindObjectOfType<GameManager>();
			return GameManager.gm;
		}
	}
	public GameObject PauseCanvas;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			PauseGame ();
			if ( pausedC == true)
				PauseCanvas.SetActive(true);
			else 
				PauseCanvas.SetActive(false);
		}
			
	}

	public void PauseGame(){
		paused = !paused;
		pausedC = !pausedC;
	}
}
