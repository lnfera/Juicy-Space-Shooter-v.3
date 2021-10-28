using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLaser : NewWeapons
{
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
        //En laser spawnar och skickas med en kraft uppåt.
        base.Fire();
        Rigidbody2D instantiatedProjectile = Instantiate(LaserBody, transform.position, Quaternion.Euler(0, 0, 0));
        instantiatedProjectile.AddForce(transform.up * 500);

    }
}
