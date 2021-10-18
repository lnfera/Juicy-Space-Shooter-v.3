using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public NewLaser laser;
    public NewSMG smg;
    public int WeaponPos = 1;

    // Start is called before the first frame update
    void Start()
    {
        smg.enabled = true;
        laser.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            WeaponPos++;
        }
        if(WeaponPos > 2)
        {
            WeaponPos = 1;
        }

        if (WeaponPos == 1)
        {
            smg.enabled = true;
            laser.enabled = false;
        }
        else if (WeaponPos == 2)
        {
            smg.enabled = false;
            laser.enabled = true;
        }

    }
}
