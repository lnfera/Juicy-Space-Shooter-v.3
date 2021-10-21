using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Update()
    {//on Escape go back to the menu
        if (Input.GetKey("escape")) 
        {
            EnterMenuScreen();
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    public void EnterOptionsMenu() 
    {
        SceneManager.LoadScene("OptionsScene");
    
    }
    public void EnterMenuScreen() 
    {

        SceneManager.LoadScene("Menu Scene");
    }
}