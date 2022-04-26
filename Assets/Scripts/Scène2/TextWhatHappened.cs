using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWhatHappened : MonoBehaviour
{
    public GameObject textWhatHappened;
    void Start()
    {
        textWhatHappened.SetActive(false);
        StartCoroutine("displayText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator displayText()
    {
        yield return new WaitForSeconds(6);
        textWhatHappened.SetActive(true);
        yield return new WaitForSeconds(12);
        textWhatHappened.SetActive(false);
    }
}
