using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageTheLastScene : MonoBehaviour
{

    public GameObject image;
    public GameObject sound;

    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(false);
        sound.SetActive(false);
        StartCoroutine("momentLater");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator momentLater()
    {
        yield return new  WaitForSeconds(10);
        image.SetActive(true);
        sound.SetActive(true);

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("FinalSceneChoice2");
    }
}
