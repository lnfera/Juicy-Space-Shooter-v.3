using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //Skrivet av Rustam
    public int Damage;
    public bool Dissapears;
    public float Timer;
    // Start is called before the first frame update

    private void Start()
    {
        StartCoroutine(Despawn());
        //S� fort spelet startas s� p�b�rjar countdownen
    }
    void OnTriggerEnter2D(Collider2D col) //Under kollisionen s� aktiverar den voiden f�r att ta damage ifall objektet �r en enemy
    {
        if (col.gameObject.name == "Enemy")
        {
            col.gameObject.GetComponent<enemyScript>().takeDamage(Damage);
        }
        if (Dissapears == true) //Skottet f�rsvinner n�r det kolliderar ifall variabeln �r sann (F�r att skilja p� olika typer)
        {
            Destroy(this.gameObject);
        }
        
    }
    IEnumerator Despawn()
    {
        yield return null;
        yield return new WaitForSeconds(Timer);
        Destroy(this.gameObject);
        //F�r kulan att automatiskt f�rsvinna om x sekunder om det r�r inget
    }
}
