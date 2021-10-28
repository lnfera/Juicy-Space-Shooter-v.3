using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSMG : NewWeapons
{
    //Skrivet av Rustam  
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
            //När man trycker på space så påbörjar skjutfunktionen
        }
    }
    public override void Fire()
    {
        base.Fire();
        Rigidbody2D instantiatedProjectile = Instantiate(BulletBody, transform.position, Quaternion.Euler(0, 0, 0));
        instantiatedProjectile.AddForce(transform.up * 1500);
        //En kula spawnar och skickas med en kraft uppåt.
    }
}
