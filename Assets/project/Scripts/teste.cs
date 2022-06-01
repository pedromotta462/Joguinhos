using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teste : MonoBehaviour {

	public List<GameObject> objs;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		objs = new List<GameObject> (GameObject.FindGameObjectsWithTag ("fire"));

		if (objs.Count == 0) {
			SceneManager.LoadScene ("win");
		}
		
	}
}
