using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinengchange : MonoBehaviour {
    private PlayerColler playercoller;

    public GameObject Guangqiu;
    public GameObject Erjineng;
    private GameObject TargetBody;
    public float TargetBodyRotateLerp = 0.3f;
    // Use this for initialization
    void Start () {
        playercoller = GetComponent<PlayerColler>();
        TargetBody = transform.parent.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
       
}

    public void Attack1()
    {
        Instantiate(Guangqiu, transform.position+new Vector3(0, 1.42f,0), transform.rotation);
      
    }
  

    public void Attack2()
    {
        Instantiate(Erjineng, transform);
      
    }

    
}
