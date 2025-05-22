using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("CowboyAnimProject"); 
    }

    public void QuitGame()
    {
        Application.Quit();
        // Debug.Log added so you can see it work in Editor
        Debug.Log("Game Quit");
    }
}
