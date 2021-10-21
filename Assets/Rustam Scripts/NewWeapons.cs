using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWeapons : MonoBehaviour
{
    public GameObject Bullet;
    public Rigidbody2D BulletBody;
    public GameObject Laser;
    public Rigidbody2D LaserBody;

    //Grundscriptet som alla vapen ärver från
    public virtual void Fire()
    {
        //print("I am a weapon");
    }
}
