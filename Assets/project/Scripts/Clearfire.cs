using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearfire : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, 5f);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "fire") {			
			Destroy (this.gameObject);
			Destroy (col.gameObject);
		}
	}
}
