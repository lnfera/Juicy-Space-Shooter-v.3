using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void startGame()
    {
       SceneManager.LoadScene (MenuScene)

    }
    public class Exit : MonoBehaviour
    {
        public void exitgame()
        {
            Debug.Log("exitgame");
            Application.Quit();
        }
    }

}