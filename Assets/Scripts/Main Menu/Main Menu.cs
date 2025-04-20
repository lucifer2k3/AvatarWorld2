using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Farm");
    }
    public void LoadGame()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
    public void Credit()
    {
    }
}
