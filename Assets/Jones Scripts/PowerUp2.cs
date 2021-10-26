using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    public float Timer;

    public float SpeedChange;
    bool HasStarted;

    float StartingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        StartingSpeed = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(HasStarted == true)
        {
            Timer -= 1 * Time.deltaTime;
            if(Timer <= 0)
            {
                HasStarted = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().speed = StartingSpeed;
                Destroy(this.gameObject);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<PlayerController>().speed += SpeedChange;
            HasStarted = true;
            Destroy(this.gameObject.GetComponent<MeshRenderer>());
            Destroy(this.gameObject.GetComponent<Collider>());

        }
    }
}
