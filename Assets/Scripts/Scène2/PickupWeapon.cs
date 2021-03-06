using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWeapon : MonoBehaviour
{
   
    public Transform gunPosition;
    public GameObject arm, spawnEnnemies,soundMusiqueBackground, textPickupWeapon, count;
    private bool isTrigered;
    private bool notDisplayText;
   

    void Start()
    {
        arm.SetActive(false);
        spawnEnnemies.SetActive(false); 
        soundMusiqueBackground.SetActive(false);
        textPickupWeapon.SetActive(false);
        count.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P) && isTrigered == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = gunPosition;
            arm.SetActive(true);
            spawnEnnemies.SetActive(true);
            count.SetActive(true);
            soundMusiqueBackground.SetActive(true);
            textPickupWeapon.SetActive(false);
            transform.rotation = Quaternion.Euler(gunPosition.rotation.x , gunPosition.rotation.y, gunPosition.rotation.z);
            transform.position = new Vector3(gunPosition.position.x, gunPosition.position.y, gunPosition.position.z);
            notDisplayText = true;

        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            isTrigered=true;
            textPickupWeapon.SetActive(true);
           

            if(notDisplayText == true)
            {
                textPickupWeapon.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        isTrigered = false;
        textPickupWeapon.SetActive(false);
    }
}
