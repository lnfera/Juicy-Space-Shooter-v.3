using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
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

}