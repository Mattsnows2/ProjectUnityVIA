using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadLetter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textReadLetter;
    public GameObject displayLetter;
    private bool isTriggered;
    void Start()
    {
        textReadLetter.SetActive(false);
        displayLetter.SetActive(false);
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && isTriggered==true)
        {
         
            displayLetter.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textReadLetter.SetActive(true);
            isTriggered=true;

        }
       
    }

    void OnTriggerExit(Collider other)
    {
        textReadLetter.SetActive(false);
        displayLetter.SetActive(false);
        isTriggered = false;
    }
}
