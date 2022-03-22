using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipLastSceneChoice2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed =4;
    [SerializeField] private GameObject explosion;
    public GameObject soundExplosion;
    void Start()
    {
        Destroy(gameObject, 5f);
        soundExplosion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += new Vector3(1f*speed*Time.deltaTime, 1f*speed*Time.deltaTime, 0f);
    

    }
    void OnDestroy()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        soundExplosion.SetActive(true);
    }
}
