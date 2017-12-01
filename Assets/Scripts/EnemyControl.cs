using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    private Rigidbody2D rb;
    public float Force;
    public float Protection;
    private float check;
    public GameObject Player;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        check = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Player.GetComponent<Rigidbody2D>().IsSleeping() == false)
        {
            rb.velocity = new Vector2((-1) * Force * check, rb.velocity.y);         //moving of enemy
            if (transform.position.x < -20)
                Destroy(gameObject);                                                //destroy enemy after position of player 
            if(Protection <= 0)
            {
                Destroy(gameObject);                                                //destroy enemy when player kill him
            }
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")                                              //gameover when enemy kill player
        {
            check = 0;
            rb.Sleep();
        }
        if (collision.tag == "Bullet")
        {
            Protection -= 1;
        }
    }
}
