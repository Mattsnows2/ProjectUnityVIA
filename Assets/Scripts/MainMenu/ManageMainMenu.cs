using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPlay()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OnSettings()
    {

    }

    public void OnExit()
    {
        Application.Quit();
    }
}
