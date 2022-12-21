using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColler : MonoBehaviour {

    // Use this for initialization
    public Animation anim;
    public int att=0;

   
    private Transform playerhit;
    public float juli= 4f;
    public float SPEED = 4F;
    private Healp hp;
   // private bool isATT;

   
    void Start () {
        anim = GetComponent<Animation>();
        playerhit = GameObject.FindGameObjectWithTag("playerHit").transform;
        hp = transform.parent.GetComponent<Healp>();
      //  gamecoll = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameColler>();
      

    }
	
	// Update is called once per frame
	void Update () {

        if (hp.m_life <= 0)
        {
            att = 5;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        transform.LookAt(transform.position + new Vector3(x,0,z));
       
        if (x == 0 && z == 0)
        {
            anim.CrossFade("Idle");
           
        }
        else
        {
            anim.CrossFade("Walk");
            transform.parent.Translate(transform.forward * -SPEED * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {           
            att = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.parent.GetComponent<Rigidbody>().AddForce(Vector3.up * 250);
        }

     



        switch (att)
        {
            case 0:
                return;
                
            case 1:
                anim.Play("Attack1");
               
                break;
            case 2:
                anim.Play("Attack2");
               
                break;
            case 3:
                anim.Play("Attack3");
               
                break;
            case 4:
                anim.Play("Wound");

                break;
            case 5:
                anim.Play("Death");

                break;
        }

       

    }

    
    public void fuwei()
    {

        att = 0;

    }

    public GameObject siwangjm;
    public void siwang()
    {
        siwangjm.SetActive(true);
       

    }


}
