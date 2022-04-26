using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScene1 : MonoBehaviour
{
    public GameObject text;
    void Start()
    {
        text.SetActive(false);
        StartCoroutine("displayText");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator displayText()
    {
        yield return new WaitForSeconds(7);
        text.SetActive(true);
    }
}
