using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageSoundFirstScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject soundBirds;
    public GameObject soundSirene;
    public GameObject soundPanique;
    public GameObject rain;
    public GameObject image;
    public GameObject deafSound;

    void Start()
    {
        soundBirds.SetActive(true);
        soundSirene.SetActive(false);
        soundPanique.SetActive(false);
        rain.SetActive(false);
        image.SetActive(false);
        deafSound.SetActive(false);

        StartCoroutine("func");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator func()
    {
       
        yield return new WaitForSecondsRealtime(7);
        soundBirds.SetActive(false);
        soundSirene.SetActive(true);
        soundPanique.SetActive(true);
        rain.SetActive(true);

        yield return new WaitForSeconds(13);
        image.SetActive(true);
        deafSound.SetActive(true);
        soundSirene.SetActive(false);
        soundPanique.SetActive(false);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Scene2");

    }
}
