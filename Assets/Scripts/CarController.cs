using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    [SerializeField] private float rotationalSpeed;
    public GameObject textToEnterInTheCar, textCannotEnter;
    public GameObject player;
    public GameObject camera;
    private bool isTriggered=false;
    public Animator anim;
    private bool hasKey = false;

    void Start()
    {
        textToEnterInTheCar.SetActive(false);
        anim = GetComponent<Animator>();
        camera.SetActive(false);
        textCannotEnter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        textCannotEnter.SetActive(false);
        if (Input.GetKeyDown("t") && isTriggered == true && hasKey==true)
        {
            player.SetActive(false);
            camera.SetActive(true);
            anim.SetBool("isWorking", true);
            StartCoroutine("changeScene3");
        }
        else if (Input.GetKey("t") && isTriggered == true && hasKey == false)
        {
            textToEnterInTheCar.SetActive(false);
            textCannotEnter.SetActive(true);
        }
        
       

    }

    public void takeKey()
    {
        hasKey = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textToEnterInTheCar.SetActive(true);
            textCannotEnter.SetActive(false);
            isTriggered = true;
        }
    }

    IEnumerator changeScene3()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Scene3");
    }
}
