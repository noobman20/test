using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jinengqiu : MonoBehaviour {
  
    public int attack;
    public int attack1min;
    public int attack1max;
   
    // Use this for initialization
    void Start () {
        Destroy(this.gameObject,0.8f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);

       
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            attack = Random.Range(attack1min, attack1max);
            col.gameObject.GetComponent<EnemyMove>().m_life -= attack;
            EnemyMove enemy = col.transform.gameObject.GetComponent<EnemyMove>();
            col.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().fillAmount = enemy.m_life / enemy.m_lifemax;

            Destroy(this.gameObject);
        }

    }
}
