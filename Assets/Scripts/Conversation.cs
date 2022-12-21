using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour {

	public GameObject jjjj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Playerzt")
        {
			jjjj.SetActive(true);

		}
    }
}
