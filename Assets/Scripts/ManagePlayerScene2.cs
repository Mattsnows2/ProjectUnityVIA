using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePlayerScene2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject cameraCinematic;
    public GameObject soundZombie;
    
    void Start()
    {
        player.SetActive(false);
        cameraCinematic.SetActive(true);
        StartCoroutine("WaitBeforePlayerAppear");
        soundZombie.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitBeforePlayerAppear()
    {
        yield return new WaitForSeconds(6);
        player.SetActive(true);
        cameraCinematic.SetActive(false);
        soundZombie.SetActive(true);
      

    }
}
