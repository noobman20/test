using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameColler : MonoBehaviour {

    public Image playerxt;
    public Text xl;
    private Healp healp;
    public GameObject zantingjiemian;
    public GameObject cundang;
   
    // Use this for initialization
    void Start () {
        healp = GameObject.FindGameObjectWithTag("Playerzt").GetComponent<Healp>();
        zantingjiemian.SetActive(false);
        cundang.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        playerxt.fillAmount = healp.m_life / healp.xueliangmax;
        xl.text = healp.m_life.ToString();

        if (ETCInput.GetButtonDown("zanting"))
        {
            Invoke("ttttt", 0.5f);
            zantingjiemian.SetActive(true);
        }
        if (ETCInput.GetButtonDown("jixu"))
        {
            Time.timeScale = 1;
            zantingjiemian.SetActive(false);
        }
        if (ETCInput.GetButtonDown("cundang"))
        {
           
            zantingjiemian.SetActive(false);
            cundang.SetActive(true);
        }
        if (ETCInput.GetButtonDown("zhucaidan"))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("login");
           
        }

    }

   public void xiangjiyd()
    {
     
    }
    public void xiangjibyd()
    {
      
    }

    void ttttt()
    {
        Time.timeScale = 0;
    }
}
