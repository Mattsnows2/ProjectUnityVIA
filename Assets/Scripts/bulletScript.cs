using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody rb;
    public int damageEnnemy=50;
    public Ennemy ennemy;
    void Start()
    {
        rb.velocity = transform.forward * speed;
       
    }

    void OnTriggerEnter(Collider other)
    {
        ennemy= GameObject.FindObjectOfType(typeof(Ennemy)) as Ennemy;

        if (ennemy)
        {
            ennemy.takeDamage(damageEnnemy);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject,5);
        }

       
    }

    
}
