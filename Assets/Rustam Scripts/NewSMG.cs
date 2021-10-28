using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSMG : NewWeapons
{
    private bool StopShoot = false;
    //Skrivet av Rustam  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (StopShoot == false)
            {
                Fire();
            }
            //När man håller ner space så påbörjar skjutfunktionen och man skjuter automatiskt
        }
    }
    public override void Fire()
    {
        base.Fire();
        StartCoroutine(FirePause());

    }
    IEnumerator FirePause()
    {
        //Cooldownen startas
        StopShoot = true;
        yield return null;

        //En kula spawnar och skickas med en kraft uppåt.
        Rigidbody2D instantiatedProjectile = Instantiate(BulletBody, transform.position, Quaternion.Euler(0, 0, 0));
        instantiatedProjectile.AddForce(transform.up * 1500);

        //0.25 Sekunder senare slutar cooldownen
        yield return new WaitForSeconds(0.25f);
        StopShoot = false;
    }
}
