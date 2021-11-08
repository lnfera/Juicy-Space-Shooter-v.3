using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//skrivet av Jones
public class Border: MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)  //En trigger som gör det möjligt för spelaren att gå igenom mapen 
    {
        print("jag testar");
        if (other.tag == "Player") // ifall objektet träffar spelaren
        {

            Destroy(other.gameObject);     // Förstör spelaren ifall han går igenom objektet 
        }

    }
}
