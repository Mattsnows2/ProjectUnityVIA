using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayMenuPause : MonoBehaviour
{
    public GameObject menuPause;
    private bool menuPauseIsActive;
    void Start()
    {
        menuPause.SetActive(false);
        menuPauseIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuPauseIsActive==false)
            {
                menuPause.SetActive(true);
                Time.timeScale = 0;
                menuPauseIsActive = true;
            }
            else if(menuPauseIsActive==true)
            {
                menuPause.SetActive(false);
                Time.timeScale = 1;
                menuPauseIsActive = false;
            }
          
        }

        
    }

    public void onResume()
    {
        menuPauseIsActive = false;
    }

    public void onSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void onExit()
    {
        Application.Quit();
    }
}
