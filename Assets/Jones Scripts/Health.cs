using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Health : MonoBehaviour
{
    public GameObject[] hearts;

    public int life;

    private bool dead;

    private GameObject[] objektet;

    private void Start()
    {
        life = hearts.Length;
        objektet = GameObject.FindGameObjectsWithTag("objektet");
    }

    // Update is called once per frame

    
    void Update()
    {
        if (dead == true)
        {
            Debug.Log("jag dog!!!");
            SceneManager.LoadScene("Deathscene");
        }
    }
    public void TakeDamage(int d)
    {
        if (life >= 1)  
        {
            life -= d; 
            Destroy(hearts[life].gameObject);
            if (life <= 0) 
                {
                dead = true;  // ifall liv är större än 1 så dör du 

                }
            else   // om inte 
            {
                dead = false;  // Så lever du
            }
        }
    }
}

