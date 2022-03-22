using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    [SerializeField] private float rotationalSpeed;
    public GameObject textToEnterInTheCar;
    public GameObject player;
    public GameObject camera;
    private bool isTriggered=false;
    public Animator anim;

    void Start()
    {
        textToEnterInTheCar.SetActive(false);
        anim = GetComponent<Animator>();
        camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
           
            transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }
        if (Input.GetKey("i"))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.back);
        }
        if (Input.GetKey("j")){
            transform.Rotate(Vector3.up, -Time.deltaTime * rotationalSpeed);
        }
        if (Input.GetKey("l")){
            transform.Rotate(Vector3.up, Time.deltaTime * rotationalSpeed);
        }
        if(Input.GetKeyDown("t") && isTriggered == true)
        {
            player.SetActive(false);
            camera.SetActive(true);
            anim.SetBool("isWorking", true);
            StartCoroutine("changeScene3");
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textToEnterInTheCar.SetActive(true);
            isTriggered = true;
        }
    }

    IEnumerator changeScene3()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Scnene3");
    }
}
