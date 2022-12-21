using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meumshijain : MonoBehaviour {

    public GameObject Huadong;
    public float speed=150;
    public GameObject dtlb;
    private bool liebiaojinru = false;
    private MapMark dituID; 
    // Use this for initialization
    void Start () {
      //  dituID = GameObject.FindGameObjectWithTag("ditubiaoshi").GetComponent<ditubiaoshi>();
	}
	
	// Update is called once per frame
	void Update () {
        float V = ETCInput.GetAxis("xshdv");
        if (V > 0.2)
        {
            Huadong.GetComponent<Animation>().Play("kaishihuadong");
        }

        if (ETCInput.GetButtonDown("cxks"))
        {
            SceneManager.LoadScene("xuanjue");
        }
        if (ETCInput.GetButtonDown("zryx"))
        {
            dtlb.GetComponent<Animator>().SetInteger("donghua",1);
            liebiaojinru = true;
        }
        if (ETCInput.GetButtonDown("Exit"))
        {
            Application.Quit();
        }
        if (ETCInput.GetButtonDown("fanhiu"))
        {
            if (liebiaojinru)
            {
                dtlb.GetComponent<Animator>().SetInteger("donghua", 2);
                liebiaojinru = false;
            }
            else
            {
                Huadong.GetComponent<Animation>().Play("fanhiu");
            }
        }


        if (ETCInput.GetButtonDown("chentangguan"))
        {
            SceneManager.LoadScene("Level1");

        }
        if (ETCInput.GetButtonDown("zhaogecheng"))
        {
            SceneManager.LoadScene("Level2");
        }
        if (ETCInput.GetButtonDown("jiexiang"))
        {
            SceneManager.LoadScene("Level3");
        }
        if (ETCInput.GetButtonDown("querenditu"))
        {
            SceneManager.LoadScene("xuanjue");
        }

    }
}
