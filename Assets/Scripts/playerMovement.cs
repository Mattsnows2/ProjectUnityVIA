using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;
    public float health = 100;
    public GameObject ImageGameOver;
  

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        ImageGameOver.SetActive(false);
    }
  
    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); 

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.right*x + transform.forward*z;

        controller.Move(movement*speed*Time.deltaTime);
     

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
           
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    public void takeDamage(int damage)
    {
        health -= damage;

        if(health < 0)
        {
            ImageGameOver.SetActive(true);
            StartCoroutine("death");
           
            //Debug.Log("die");
        }
    }

    IEnumerator death()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
