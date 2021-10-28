using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShotgun : NewWeapons
{
    //Skrivet av Rustam  
    public float amount;
    public int shellcount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
            //N�r man trycker p� space s� p�b�rjar skjutfunktionen
        }
    }   
    public override void Fire()
    {
        base.Fire();
        //F�r varje shell i shellcount s� skjuts ut en kula.
        for (int i = 0; i < shellcount; i++)
        {
            //Varje kula har en slumpm�ssig rotation mellan amount och -amount. 
            Quaternion spread = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, Random.Range(-amount, amount)));
            Rigidbody2D instantiatedProjectile = Instantiate(BulletBody, transform.position, spread);
            instantiatedProjectile.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 1500);
            //En kula spawnar och skickas med en kraft upp�t.
        }
    }

}
