using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hangar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject buttonsChoices, explosion, textHangar, CameraEnd, player, explosionPosition;
    public bool isRunning;




    void Start()
    {
        buttonsChoices.SetActive(false);
      
        textHangar.SetActive(false);
        CameraEnd.SetActive(false);
        player.SetActive(true);
        isRunning = true;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            buttonsChoices.SetActive(true);
            explosion.SetActive(true);
            textHangar.SetActive(true);
            StartCoroutine("Choice");
            CameraEnd.SetActive(true);
            player.SetActive(false);

            StartCoroutine("Explostion");
          
        }
    }

    IEnumerator Explostion()
    {
        while (isRunning == true)
        {

            yield return new WaitForSeconds(2);
            Instantiate(explosion, explosionPosition.transform.position, Quaternion.identity);
        }
    }



}
