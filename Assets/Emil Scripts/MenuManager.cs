using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // av Emil
    public void Update()
    {//on Escape go back to the menu
        if (Input.GetKey("escape")) 
        {
            EnterMenuScreen();
        }
    }
    //startar själva spel scenen 
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    //stänger ner game applicationen.
    public void Exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    //öppnar Options menu
    public void EnterOptionsMenu() 
    {
        SceneManager.LoadScene("OptionsScene");
    
    }
    //återvänder till huvudmenyn
    public void EnterMenuScreen() 
    {

        SceneManager.LoadScene("Menu Scene");
        
    }
}