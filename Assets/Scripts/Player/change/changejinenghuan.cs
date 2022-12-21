using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changejinenghuan : MonoBehaviour {
    public int attack;
    public int attack1min;
    public int attack1max;
 
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 1.4f);
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            attack = Random.Range(attack1min, attack1max);
            col.gameObject.GetComponent<EnemyMove>().m_life -= attack;
            EnemyMove enemy = col.transform.gameObject.GetComponent<EnemyMove>();
            col.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().fillAmount = enemy.m_life / enemy.m_lifemax;

           
        }

    }
}
