using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//skrivet av Jones 

public class Health : MonoBehaviour
{
    //variabler 

    public GameObject[] hearts; 

    public int life;

    private bool dead;

    private GameObject[] objektet;

    private void Start()
    {
        life = hearts.Length; //liven 
        objektet = GameObject.FindGameObjectsWithTag("objektet"); //hitta tag 
    }

    // Update is called once per frame

    
    void Update()
    {
        if (dead == true) // om den är död
        {
            Debug.Log("jag dog!!!");
            SceneManager.LoadScene("Deathscene"); //ladda scenen deathscene
        }
    }
    public void TakeDamage(int d) 
    {
        if (life >= 1)  //om liv är större eller lika med 1 
        {
            life -= d; // ta damage
            Destroy(hearts[life].gameObject); //gör så att det finns elements av liv i inspektorn
            if (life <= 0) // om liv är mindre än 0 eller lika med 0 
                {
                dead = true;  // så dör du

                }
            else   // om inte 
            {
                dead = false;  // Så lever du
            }
        }
    }
}

