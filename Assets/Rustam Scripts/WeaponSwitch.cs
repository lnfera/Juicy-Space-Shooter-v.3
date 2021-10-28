using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    //Skrivet av rustam
    public NewLaser laser;
    public NewSMG smg;
    public NewShotgun shotgun;
    public int WeaponPos = 1;

    // Start is called before the first frame update
    void Start()
    { //Ser till att man börjar med smgn
        smg.enabled = true;
        laser.enabled = false;
        shotgun.enabled = false;
    }

    // Update is called once per frame
    void Update()
    { //När man trycker på e så cyclas listan av vapen
        if (Input.GetKeyDown(KeyCode.E))
        {
            WeaponPos++;
        }
        if(WeaponPos > 3) //Gör så att listan loopar
        {
            WeaponPos = 1;
        }

        if (WeaponPos == 1) //Om listan är på 1 så disablas laserscriptet och smgscriptet enablas
        {
            smg.enabled = true;
            laser.enabled = false;
            shotgun.enabled = false;
        }
        else if (WeaponPos == 2) //Om listan är på 2 så disablas smgn och lasern enablas.
        {
            smg.enabled = false;
            laser.enabled = true;
            shotgun.enabled = false;
        }
        else if (WeaponPos == 3) //Om listan är på 3 så enablas lasern och allt annat disablas.
        {
            smg.enabled = false;
            laser.enabled = false;
            shotgun.enabled = true;
        }
    }
}
