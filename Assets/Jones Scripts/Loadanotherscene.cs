using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

//skrivet av Jones
public class Loadanotherscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public void LoadScene(string sceneName) //om jag skriver scenes namn i funktionen av button
    {
        SceneManager.LoadScene("Menu Scene"); //ladda scenen

    }
}
