using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nezhajinenger : MonoBehaviour {

    public int attack;
    public int attack1min;
    public int attack1max;
    public float time=0.6f;
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            if (col.transform.gameObject.GetComponent<EnemyMove>())
            {
                EnemyMove enemy = col.transform.gameObject.GetComponent<EnemyMove>();

                // col.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().fillAmount = enemy.m_life / enemy.m_lifemax;
                enemy.shouji = true;
            }
            if (col.transform.gameObject.GetComponent<EnemyMove1>())
            {
                EnemyMove1 enemy1 = col.transform.gameObject.GetComponent<EnemyMove1>();
                enemy1.shouji = true;
            }
        }

    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            attack = Random.Range(attack1min, attack1max);
            if (col.transform.gameObject.GetComponent<EnemyMove>())
            {
                col.gameObject.GetComponent<EnemyMove>().m_life -= attack;
                EnemyMove enemy = col.transform.gameObject.GetComponent<EnemyMove>();
                col.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().fillAmount = enemy.m_life / enemy.m_lifemax;
                enemy.m_animator.Play("Wound");
            }
            if (col.transform.gameObject.GetComponent<EnemyMove1>())
            {
                col.gameObject.GetComponent<EnemyMove1>().m_life -= attack;
                EnemyMove1 enemy = col.transform.gameObject.GetComponent<EnemyMove1>();
                col.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().fillAmount = enemy.m_life / enemy.m_lifemax;
                enemy.m_animator.Play("Wound");
            }


        }

    }
}
