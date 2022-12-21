using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changekongzhi : MonoBehaviour {

    private PlayerColler playercoller;
	// Use this for initialization
	void Start () {
        playercoller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerColler>();
        GetComponent<Image>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TouchStar()
    {
        GetComponent<Image>().enabled = true;
    }
    public void TouchOver()
    {
        playercoller.att = 1;
        GetComponent<Image>().enabled = false;
    }
}
