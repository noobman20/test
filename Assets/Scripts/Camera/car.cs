using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour {

    private GameObject player;
	public Vector3 lll;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = player.transform.position+lll;
	}
}
