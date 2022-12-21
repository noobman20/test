using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class xuanzejuese : MonoBehaviour {
   
    public float Speed = 5;

    public Transform pingtai;
    public GameObject nezha;
    public GameObject change;
    private GameObject Player;
  


	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        Player = GameObject.FindGameObjectWithTag("Playerzt");

        if (ETCInput.GetButtonDown("nezha"))
        {
            Destroy(Player);
            Instantiate(nezha, pingtai);
         
        }
       


        if (ETCInput.GetButtonDown("jinruyouxi"))
        {
           
                SceneManager.LoadScene("Level1");
         

        }
    }


}
