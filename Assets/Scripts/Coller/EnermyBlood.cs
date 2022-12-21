using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyBlood : MonoBehaviour {

    public GameObject ShowBlood;
	// Use this for initialization
	void Start () {
      
        Instantiate(ShowBlood, this.gameObject.transform);
      
    }
	
	// Update is called once per frame
	void Update () {

	}
}
