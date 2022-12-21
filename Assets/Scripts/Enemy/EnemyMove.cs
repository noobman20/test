using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : MonoBehaviour
{

    Transform m_transform;
    //CharacterController m_ch;

   public Animation m_animator;

    NavMeshAgent m_agent;

    private Transform poone;
    private Transform potwo;

    PlayerColler m_player;
    public float attplay = 4f;
    Healp PlayerHP;
    float m_moveSpeed = 0.5f;
    float m_rotSpeed = 200;
   public float m_life = 15;
    public float m_lifemax = 15;

    float m_timer = 2;
    private int GONGJILI;
    public int GONGJILIMIN1;
    public int GONGJILIMAX1;
    public int GONGJILIMIN2;
    public int GONGJILIMAX2;
    public float swsj = 2.16f;
    private int i=0;

   
    public bool shouji=false;
    void Start()
    {
        m_life = m_lifemax;
        poone = transform.parent.gameObject.transform.Find("poone").transform;
        potwo = transform.parent.gameObject.transform.Find("potwo").transform;
        m_transform = this.transform;

        m_animator = this.GetComponent<Animation>();

        m_agent = GetComponent<NavMeshAgent>();

       
       
       
        m_agent.destination = poone.position;
    }

    void Update()
    {
        m_player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerColler>();
        PlayerHP = GameObject.FindGameObjectWithTag("Playerzt").GetComponent<Healp>();


        if (PlayerHP.m_life <= 0)
        {
            return;
        }

        if (m_life > 0)
        {

            m_timer -= Time.deltaTime;

        if (Vector3.Distance(m_transform.position, m_player.transform.position) < attplay)
        {
                transform.LookAt(m_player.transform);
                if (!shouji)
                {
                    if (i == 0 || i == 1)
                    {
                        m_animator.Play("Attack1");
                      
                    }
                    if (i == 2)
                    {
                      
                      m_animator.Play("Attack2");
                    }
                }
                else
                {
                    m_animator.Play("Wound");
                }
        }
            else if (Vector3.Distance(m_transform.position, m_player.transform.position) > 6f)
            {
                if (Vector3.Distance(transform.position, poone.position) < 4)
                {
                    print("ll");
                    m_agent.destination = potwo.position;
                    m_animator.Play("Run");
                }
                if (Vector3.Distance(transform.position, potwo.position) < 4)
                {
                    m_animator.Play("Run");
                    m_agent.destination = poone.position;
                    m_animator.Play("Run");
                }
            }
                 
            else
        {
           
            m_timer = 1;
          
            m_agent.SetDestination(m_player.transform.position);
          
            m_animator.Play("Run");
        }


    }
        if (m_life<=0)
        {
           
            Destroy(this.GetComponent<Collider>());
            m_animator.Play("Death");
            if (!lajjj)
            {
                if (PlayerHP.m_life < PlayerHP.xueliangmax - 10)
                    PlayerHP.m_life += 10;
                else
                    PlayerHP.m_life = PlayerHP.xueliangmax;
               lajjj = true;
            }
           m_agent.speed = 0;
            Destroy(gameObject.transform.parent.gameObject, swsj);
           



        }

       
        
    }

    bool lajjj = false;

  
    void MoveTo()
    {
       
        float speed = m_moveSpeed * Time.deltaTime;

       
        m_agent.Move(m_transform.TransformDirection(new Vector3(0, 0, speed)));
    }


    
    void RotationTo()
    {
        
        Vector3 oldAngle = m_transform.eulerAngles;
     
        m_transform.LookAt(m_player.transform);

       
        float target = m_transform.eulerAngles.y;
       
        float speed = m_rotSpeed * Time.deltaTime;
       
        float angle = Mathf.MoveTowardsAngle(oldAngle.y, target, speed);

       
        m_transform.eulerAngles = new Vector3(0, angle, 0);
    }


    public void Attack1()
    {
        GONGJILI = Random.Range(GONGJILIMIN1, GONGJILIMAX1);
        PlayerHP.m_life -= GONGJILI;
        
    }
    public void Attack1End()
    {
        i = Random.Range(0, 3);
        print(i);
    }
    public void Attack2()
    {
        GONGJILI = Random.Range(GONGJILIMIN1, GONGJILIMAX1);
        PlayerHP.m_life -= GONGJILI;
        m_player.att = 4;
        
    }
    public void Attack2End()
    {
        i = Random.Range(0, 2);
    }

    public void fuwei()
    {
       
        shouji = false;
        return;
    }
}