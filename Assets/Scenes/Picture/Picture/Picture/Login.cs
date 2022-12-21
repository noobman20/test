using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void EnterGame()
    {
       
			SceneManager.LoadScene("xuanjue");
       
    }
	public void LogOut()
    {
		Application.Quit();
		Debug.Log("LogOut");
    }

	public void Voice()
    {
		GameObject.FindGameObjectWithTag("shengyin").transform.GetChild(0).gameObject.SetActive(true);
    }


}
