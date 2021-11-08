using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//skrivet av Jones
public class PowerUp2 : MonoBehaviour
{
    public float Timer; // timer

    public float SpeedChange; // variabel f�r speedchange 
    bool HasStarted;  //Har startat

    float StartingSpeed; //variabel startingspeed
    // Start is called before the first frame update
    void Start()
    {
        //hitta spelaren med tagen player och f� component fr�n playercontroller vilket �r speed
        StartingSpeed = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().speed; 
    }

    // Update is called once per frame
    void Update()
    {
        if(HasStarted == true) // om det har b�rjat
        {
            Timer -= 1 * Time.deltaTime; //timern 
            {
                HasStarted = false; //detta �r att power up inte �r p�
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().speed = StartingSpeed; //hitta spelare med tagen player och g�r att speed �r lika med startingspeed
                Destroy(this.gameObject); //f�rst�r objektet
                 
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") //om den tr�ffar spelaren
        {
            collision.GetComponent<PlayerController>().speed += SpeedChange; //H�mta component fr�n spelarskripten addera den med speedchange 
            HasStarted = true; //har den b�rjat
            Destroy(this.gameObject.GetComponent<SpriteRenderer>()); //f�rst�r spriterenderer
            Destroy(this.gameObject.GetComponent<Collider>()); //f�rst�r collider 

        }
    }
}
