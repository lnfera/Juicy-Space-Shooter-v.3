using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border: MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)  //En trigger som g�r det m�jligt f�r spelaren att g� igenom mapen 
    {
        print("jag testar");
        if (other.tag == "Player")
        {

            Destroy(other.gameObject);     // F�rst�r spelaren ifall han g�r igenom objektet 
        }

    }
}
