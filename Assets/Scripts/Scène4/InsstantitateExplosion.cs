using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsstantitateExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    private bool running;
    public GameObject explosion, explosionPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Explosion");
    }

    IEnumerator Explosion()
    {
        while (running   == true)
        {

            yield return new WaitForSeconds(2);
            Instantiate(explosion, explosionPosition.transform.position, Quaternion.identity);
        }
    }
}


