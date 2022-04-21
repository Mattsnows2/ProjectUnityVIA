using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManageSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TMP_Dropdown Resolution;
    public AudioSource audioSource;
    public Slider sliderSound;
    public Slider sliderFPS;
    public Toggle toggleVsync;
    private bool value = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetResolution()
    {
        switch (Resolution.value)
        {
            case 0:
                Screen.SetResolution(640, 360, true);
                break;

            case 1:
                Screen.SetResolution(1920, 1080, true);

                break ;
        }  
    }

    public void SliderChange()
    {
        audioSource.volume =sliderSound.value;
    }

    public void SliderFPSChange()
    {
       int sliderValueInInt = (int)Mathf.Round(sliderFPS.value * 200);
        Application.targetFrameRate = sliderValueInInt;
        print(Application.targetFrameRate);
    }

    public void ToogleChange(bool value)
    {
        if(toggleVsync.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
