using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xuetiao : MonoBehaviour {
    private GameObject Camera;
   
    // Use this for initialization
    void Start() {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
       
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(Camera.transform);

        


    }
}
