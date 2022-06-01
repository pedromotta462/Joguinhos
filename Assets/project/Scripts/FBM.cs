using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FBM : MonoBehaviour {
	public float speed;
	Rigidbody shot;
	public Rigidbody reta;

	public float ncaixas;
	public Transform braço;
	public Scrollbar life;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetMouseButtonDown(0)) {
			
			shot = Instantiate (reta, braço.position, transform.rotation)as Rigidbody;
			shot.velocity = braço.TransformDirection (new Vector3 (speed, 0, 0));
		}

		if (GameObject.FindGameObjectsWithTag("fire") == null ) {
			SceneManager.LoadScene ("win");		
		}

	}


	void OnTriggerStay(Collider col)
	{		
		if (col.gameObject.tag == "Finish") {
			life.size -= 0.01f;
			if (life.size == 0) {				
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				SceneManager.LoadScene("game over");
			}
		}
	}



}

