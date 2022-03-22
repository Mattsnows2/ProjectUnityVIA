using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwnZone : MonoBehaviour
{
    public Transform player;
    public int distanceToSpawn;
    public GameObject Ennemy;
    public int maxEnnemies=10;
    public float Distance;
    public float timeBetwenenSpawn=3f;
    public float nextSpawn;
    private int nbrEnnemies;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(transform.position, player.position);

        if (Distance < distanceToSpawn && nbrEnnemies< maxEnnemies)
        {
            if(Time.time > nextSpawn)
            {
                nextSpawn = Time.time + timeBetwenenSpawn;
                Instantiate(Ennemy, transform.position, Quaternion.identity);
                nbrEnnemies++;
            }
        }
    }
}
