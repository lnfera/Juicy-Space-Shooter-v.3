using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLaser : NewWeapons
{
    private bool StopShoot = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Om man är off cooldown så kan man skjuta lasern
            if (StopShoot == false)
            {
                Fire();
            }
            //När man trycker på space så påbörjar skjutfunktionen
        }
    }
    public override void Fire()
    {
        //Startar courotinen
        StartCoroutine(FirePause());
        base.Fire();
        
    }
    IEnumerator FirePause()
    {
            //Cooldownen startas
            StopShoot = true;

            //En laser spawnar och skickas med en kraft uppåt.
            Rigidbody2D instantiatedProjectile = Instantiate(LaserBody, transform.position, Quaternion.Euler(0, 0, 0));
            instantiatedProjectile.AddForce(transform.up * 500);

            //5 Sekunder senare slutar cooldownen
            yield return new WaitForSeconds(5f);
            StopShoot = false;
    }
}
