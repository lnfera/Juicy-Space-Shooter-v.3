using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Loadanotherscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("Menu Scene");

    }
}
