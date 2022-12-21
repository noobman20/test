using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jieshu : MonoBehaviour {

	public EnemyMove kkk;
	public GameObject lak;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (kkk.m_life <= 0)
        {
			lak.SetActive(true);
        }
	}
}
