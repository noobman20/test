using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour {


	public GameObject biaoji;
	public AudioSource audio;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void shengyinkaiguan()
    {
		audio.enabled = !audio.enabled;
		biaoji.SetActive(audio.enabled);
    }
}
