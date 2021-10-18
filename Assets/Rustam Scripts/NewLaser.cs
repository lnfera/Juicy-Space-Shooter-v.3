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
        }
    }
    public override void Fire()
    {
        base.Fire();
        Rigidbody2D instantiatedProjectile = Instantiate(LaserBody, transform.position, Quaternion.Euler(0, 0, 0));
        instantiatedProjectile.AddForce(transform.up * 500);

    }
}
