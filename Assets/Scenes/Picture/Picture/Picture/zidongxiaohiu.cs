using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidongxiaohiu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("xs", 0.5f);
	}
	
	// Update is called once per frame
	void xs () {
		gameObject.SetActive(false);
	}
}
