using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float walkDistance;
    public float RunDistance;
    public float attackDistance;
    private float distance;
    public float health=100;
    private  Animator anim;
    private UnityEngine.AI.NavMeshAgent ennemy;
    private Vector3 EnnemiPos;
    public playerMovement playerMovement;
    public int seconds = 2;
    void Start()
    {
        ennemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        EnnemiPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);

        if(distance < walkDistance)
        {
       
            ennemy.SetDestination(player.position);
            anim.SetBool("isWalking", true);

            if (distance < RunDistance)
            {
                ennemy.SetDestination(player.position);
                anim.SetBool("isRunning", true);

                if (distance < attackDistance )
                {
                    anim.SetBool("isAttacking", true);
                    if (Time.time > seconds)
                    {
                        seconds += 1;
                        playerMovement = GameObject.FindObjectOfType(typeof(playerMovement)) as playerMovement;
                        playerMovement.takeDamage(10);
                    }

                }
                else if(distance> attackDistance)
                {
                    ennemy.SetDestination(player.position);
                    anim.SetBool("isAttacking", false);
                    anim.SetBool("isRunning", true);
                }


            }
            else if(distance>RunDistance)
            {
                ennemy.SetDestination(player.position);
                anim.SetBool("isRunning", false);
                anim.SetBool("isWalking", true);
            }

        }
        else if(distance> walkDistance)
        {
            anim.SetBool("isWalking", false);
        }
       

    }

    public void takeDamage(int damaage)
    {
        health -= damaage;

        if (health < 0)
        {
            Die();
        }
    }

    private void Die()
    {

        anim.SetBool("isDead", true);
        ennemy.SetDestination(transform.position);
        Destroy(gameObject, 1);
    }


}
