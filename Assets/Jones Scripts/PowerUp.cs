using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//skrivet av Jones
public class PowerUp : MonoBehaviour
{
    public float multiplier = 1.4f;

    public float duration = 4f;

    void onTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
     
        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.speed *= multiplier;

        yield return new WaitForSeconds(duration);

        stats.speed /= multiplier;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        Destroy(gameObject);
    }
}
