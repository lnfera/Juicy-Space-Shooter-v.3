using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//skrivet av Jones
public class PowerUp2 : MonoBehaviour
{
    public float Timer; // timer

    public float SpeedChange; // variabel för speedchange 
    bool HasStarted;  //Har startat

    float StartingSpeed; //variabel startingspeed
    // Start is called before the first frame update
    void Start()
    {
        //hitta spelaren med tagen player och få component från playercontroller vilket är speed
        StartingSpeed = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().speed; 
    }

    // Update is called once per frame
    void Update()
    {
        if(HasStarted == true) // om det har börjat
        {
            Timer -= 1 * Time.deltaTime; //timern 
            {
                HasStarted = false; //detta är att power up inte är på
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().speed = StartingSpeed; //hitta spelare med tagen player och gör att speed är lika med startingspeed
                Destroy(this.gameObject); //förstör objektet
                 
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") //om den träffar spelaren
        {
            collision.GetComponent<PlayerController>().speed += SpeedChange; //Hämta component från spelarskripten addera den med speedchange 
            HasStarted = true; //har den börjat
            Destroy(this.gameObject.GetComponent<SpriteRenderer>()); //förstör spriterenderer
            Destroy(this.gameObject.GetComponent<Collider>()); //förstör collider 

        }
    }
}
