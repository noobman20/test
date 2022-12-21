using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

	public int kk;
	public Text text;
	public int zui=40;
	public GameObject guoguan;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score：" + kk;
        if (kk >= zui)
        {
			guoguan.SetActive(true);

		}
	}
}
