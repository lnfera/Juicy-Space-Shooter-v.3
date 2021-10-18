using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int Damage;
    public bool Dissapears;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            col.gameObject.GetComponent<enemyScript>().takeDamage(Damage);
        }
        if (Dissapears == true)
        {
            Destroy(this.gameObject);
        }
        else
        {
            
        }
        /*if (col.gameObject.layer == 7)
        {
            print("jag blir prickad.");
        }*/
    }
}
