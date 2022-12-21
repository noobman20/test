using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nezhajineng : MonoBehaviour {

    private PlayerColler playercoller;

    public GameObject jinengyi;
    public GameObject jinenger;
    public GameObject jinengsan;
    // Use this for initialization
    void Start()
    {
        playercoller = GetComponent<PlayerColler>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack1()
    {
        Instantiate(jinengyi, transform);

    }
    public void Attack2()
    {
        Instantiate(jinenger, transform);

    }


    public void Attack3()
    {
        Instantiate(jinengsan, transform);

    }

}
