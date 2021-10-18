using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border: MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)  //En trigger som gör det möjligt för spelaren att gå igenom mapen 
    {
        print("jag testar");
        if (other.tag == "Player")
        {

            Destroy(other.gameObject);     // Förstör spelaren ifall han går igenom objektet 
        }

    }
}
