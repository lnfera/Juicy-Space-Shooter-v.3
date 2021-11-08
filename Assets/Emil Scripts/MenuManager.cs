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
    //startar sj�lva spel scenen 
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //st�nger ner game applicationen.
    public void Exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    //�ppnar Options menu
    public void EnterOptionsMenu() 
    {
        SceneManager.LoadScene("OptionsScene");
    
    }
    //�terv�nder till huvudmenyn
    public void EnterMenuScreen() 
    {

        SceneManager.LoadScene("Menu Scene");
        
    }
}