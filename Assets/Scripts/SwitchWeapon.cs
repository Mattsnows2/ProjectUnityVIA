using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject weapon1, weapon2;
    public bool isSwitched;
   
    void Start()
    {
        weapon1.SetActive(true);
        weapon2.SetActive(false);
        isSwitched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")){
            if (isSwitched == false)
            {
                weapon1.SetActive(false);
                weapon2.SetActive(true);
                isSwitched = true;
            }
            else
            {
                weapon2.SetActive(false);
                weapon1.SetActive(true);
                isSwitched = false;
            }
        }
    }
}
