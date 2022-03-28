using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TMP_Dropdown Resolution;
    public AudioSource audioSource;
    public Slider sliderSound;
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
}
