using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllLoader : MonoBehaviour
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

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void TwoPGameplay() {
        SceneManager.LoadScene("2_Player_Gameplay");
    } 

    public void TwoPEnterName() {
        SceneManager.LoadScene("2_Player_Enter_Name");
    }

    public void P1Card() 
    {
        SceneManager.LoadScene("P1_Card");
    }

    public void P2Card() 
    {
        SceneManager.LoadScene("P2_Card");
    }
}
