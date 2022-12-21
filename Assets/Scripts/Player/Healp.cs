using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Healp : MonoBehaviour {

   public float m_life=100;
    public float xueliangmax;
    public float fangyu;
    public GameObject kongzhiqi;

    // Use this for initialization
    void Start () {
        m_life = xueliangmax;
       // Instantiate(kongzhiqi);
    }
	
	// Update is called once per frame
	void Update () {
        if (i == 4)
        {
            Instantiate(fazhen);
            i = 10;
        }
        if (i == 5)
        {

            shu.SetActive(true);
        }
    }
   public int i;
    public GameObject shu,cg;
    public GameObject fazhen;


   

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "fabao")
        {
            i++;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "fazhen1")
        {
            cg.SetActive(true);
        }
       
    }
}
