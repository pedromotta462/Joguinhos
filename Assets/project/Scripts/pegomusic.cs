using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegomusic : MonoBehaviour {

	public FBM numcaixas;

	public float estacaixa;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player" && numcaixas.ncaixas == estacaixa) {
			Debug.Log (numcaixas.ncaixas);
			numcaixas.ncaixas = estacaixa + 1;
			Destroy (this.gameObject);
		}
	}


}
