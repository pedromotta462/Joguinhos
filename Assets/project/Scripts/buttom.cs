using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttom : MonoBehaviour {

	public bool aviso;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;	
	}
	
	// Update is called once per frame
	void Update () {
		if (aviso == true) {
			if (Time.time >= 15) {
				Destroy (this.gameObject);
			}
		}
	
	}
    public void ChangeScene(string scene)
    {
		SceneManager.LoadScene(scene);
    }

	public void exit()
	{
		Application.Quit ();
	}

}
