using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonChocie : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Buttonhoice1()
    {
        print("j'ai cliqué");
    }

    public void ButtonChoice2()
    {

        SceneManager.LoadScene("Scene4Choice1");
        print("j'ai cliqué");
    }
}
