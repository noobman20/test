using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour {

    private Swtich qiehuan;
    public GameObject[] PLAY;
   // public GameObject change;
    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        qiehuan = GameObject.FindGameObjectWithTag("QIEHUAN").GetComponent<Swtich>();

        Instantiate(PLAY[qiehuan.ID]);
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
