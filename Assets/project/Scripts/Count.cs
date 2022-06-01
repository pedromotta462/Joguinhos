using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour {

    private Text text;
    public float timeStart;
	public bool faz;
	public FBM caixa;
	float ncaxa;

	// Use this for initialization
	void Start () {

        text = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (faz) {
			ncaxa = caixa.ncaixas - 1;
			text.text = "" + ncaxa.ToString();
		} else {

			timeStart += Time.deltaTime;
			text.text = "" + Mathf.Round (timeStart) + "s";
		}

    }
}
