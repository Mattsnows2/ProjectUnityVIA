using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textToPickupAmmo;
    public shoot shoot;
    private bool isTriggered = false;
    void Start()
    {
        textToPickupAmmo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && isTriggered==true)
        {
            shoot = GameObject.FindObjectOfType(typeof(shoot)) as shoot;
            shoot.reloadWeapon(5);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag ("Player"))
        {
            isTriggered = true;
            textToPickupAmmo.SetActive(true);
          
        }
    }

    void OnTriggerExit(Collider coll)
    {
        textToPickupAmmo.SetActive(false);
    }
}
