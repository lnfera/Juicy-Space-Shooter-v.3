using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShotgun : NewWeapons
{
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
        }
    }   
    public override void Fire()
    {
        base.Fire();
        print("Trying to shoot");
        for (int i = 0; i < shellcount; i++)
        {
            print("I'm ACTUALLY SHOOTING");
            Quaternion spread = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, Random.Range(-amount, amount)));
            Rigidbody2D instantiatedProjectile = Instantiate(BulletBody, transform.position, spread);
            instantiatedProjectile.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 1500);
            print(spread);
        }
    }

}
