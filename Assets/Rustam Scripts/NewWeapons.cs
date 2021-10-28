using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWeapons : MonoBehaviour
{
    //Skrivet av Rustam
    public GameObject Bullet;
    public Rigidbody2D BulletBody;
    public GameObject Laser;
    public Rigidbody2D LaserBody;

    public AudioClip ShootSound;
    public AudioSource audioSource;

    //Grundscriptet som alla vapen ärver från
    public virtual void Fire()
    {
        audioSource.PlayOneShot(ShootSound, 1F);

    }
}
