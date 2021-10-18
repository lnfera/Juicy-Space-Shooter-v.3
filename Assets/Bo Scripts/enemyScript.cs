 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Transform tr;
    public int hp;
    public int pointValue; // hur mycket points till scoren men f�r av att d�d enemyn 
    public float speed;
    public Points points;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    private void FixedUpdate()
    {
        rb.MovePosition(new Vector2(tr.position.x, tr.position.y - speed));
    }
    public void takeDamage(int damage) // metod f�r n�r enemyn tar skada 
    {
        hp -= damage;
        if(hp <= 0)
        {
            death();
        }
    }
    void death() // metod f�r n�r enemyn d�r 
    {
        points.TotalPoints += pointValue;
        Destroy(this.gameObject);
    }
}
