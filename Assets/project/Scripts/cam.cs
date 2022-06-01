using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {

	public cam script;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= 0) {
			transform.Rotate(Vector3.left, 2 * Time.deltaTime);
		}
		if (Time.time >= 12) {
			Destroy (script);
		}



	}
}
