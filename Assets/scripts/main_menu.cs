using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    // used to load the camera and start the AR
    public void Play()
    {
        SceneManager.LoadSceneAsync("A.R_Side");
    }
    //used to close the app
    public void close()
    {
        Application.Quit();
    }

}
