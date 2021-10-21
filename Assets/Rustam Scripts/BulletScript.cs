using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int Damage;
    public bool Dissapears;
    public float Timer;
    // Start is called before the first frame update

    private void Start()
    {
        StartCoroutine(Despawn());
    }
    void OnTriggerEnter2D(Collider2D col) //Under kollisionen så aktiverar den voiden för att ta damage ifall objektet är en enemy
    {
        if (col.gameObject.name == "Enemy")
        {
            col.gameObject.GetComponent<enemyScript>().takeDamage(Damage);
        }
        if (Dissapears == true) //Skottet försvinner när det kolliderar ifall variabeln är sann (För att skilja på olika typer)
        {
            Destroy(this.gameObject);
        }
        
    }
    IEnumerator Despawn()
    {
        yield return null;
        yield return new WaitForSeconds(Timer);
        Destroy(this.gameObject);
        //Får kulan att automatiskt försvinna om 5 sekunder om det rör inget
    }
}
