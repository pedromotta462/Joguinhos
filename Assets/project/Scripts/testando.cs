using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class testando : MonoBehaviour {

    public AudioSource audio;
    Scrollbar scroll;

	// Use this for initialization
	void Start () {
        scroll = GetComponent<Scrollbar>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeVolume()
    {
        audio.volume = scroll.value;
    }

    public void Pause()
    {
        if (audio.isPlaying) {
            audio.Pause();
        } else
        {
            audio.UnPause();
        }       
       
    }
}
