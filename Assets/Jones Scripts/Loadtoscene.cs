using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadtoscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void LoadScene(string sceneName) //om jag skriver scenes namn i funktionen av button
    {
        SceneManager.LoadScene("GameScene"); //ladda scenen
    }
}
