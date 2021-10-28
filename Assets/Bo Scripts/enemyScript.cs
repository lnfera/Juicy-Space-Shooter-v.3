 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Transform tr;
    public int hp;
    public int pointValue; // hur mycket points till scoren men får av att död enemyn 
    public float speed;
    public Points points;
    public ComboCounter combocounter;

    public Health health;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        health = GameObject.FindGameObjectWithTag("objektet").GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        rb.MovePosition(new Vector2(tr.position.x, tr.position.y - speed));
    }
    public void takeDamage(int damage) // metod för när enemyn tar skada 
    {
        hp -= damage;
        if (hp <= 0)
        {
            death();
        }
    }
    void death() // metod för när enemyn dör 
    {
        ComboCounter.Combo++; //När en enemy slayas så läggs ett poäng till combo countern.
        points.TotalPoints += Mathf.RoundToInt(pointValue * (ComboCounter.Combo * 1.02f)); //Det läggs till 2% bonuspoäng per combo, vilket avrundas till en int.
        Destroy(this.gameObject); //Enemyn försvinner.
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Health sn = other.gameObject.GetComponent<Health>();
            sn.TakeDamage(1);

        }
    }
}

