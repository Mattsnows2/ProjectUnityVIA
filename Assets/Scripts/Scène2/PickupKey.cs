using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isTriggered = false;
    public GameObject textPickupKey;
    public CarController car;
    void Start()
    {
        textPickupKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k") && isTriggered==true)
        {
            car = GameObject.FindObjectOfType(typeof(CarController)) as CarController;
            car.takeKey();
            textPickupKey.SetActive(false);
            Destroy(gameObject);
        }   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textPickupKey.SetActive(true);
         
            isTriggered = true;
        }
    }
}
