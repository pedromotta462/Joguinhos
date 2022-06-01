using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnClick() {
			// call our toggle function
			doPauseToggle();
		}
	 void doPauseToggle() {
		// here we check to see if we are running at a time scale above 0
		if(Time.timeScale>0){
			// time scale is above zero, so we need to pause the game here
			pauseGame();
		} else {
			// time scale was less than zero, so we unpause the game here
			unPauseGame();
		}
	}

	void pauseGame () {
		// set scale at which time passes to 0, freezing time(!)
		Time.timeScale=0;
	}

	void unPauseGame () {
		// set scale at which time passes to 1, running at realtime again
		Time.timeScale=1;
	}
}
