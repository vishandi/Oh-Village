using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LocalPlay()
    {
        SceneManager.LoadScene("Local_Play");
    }
    
    public void OnlinePlay()
    {
        SceneManager.LoadScene("Online_Play");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("How_To_Play");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
} 
