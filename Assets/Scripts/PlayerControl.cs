using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float Power;
    public float Speed;
    private Rigidbody2D rb;
    public GameObject Body;
    public Transform Bullet;
    public GameObject PressReturn;
    public GameObject GameOver;
    public GameObject Restart;
    public GameObject Legs;
    public float Move;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (PressReturn.GetComponent<SpriteRenderer>().enabled == false)
        {
            Move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(Move * Speed, rb.velocity.y);                     //moving of player left or right
            if (Input.GetKeyDown("up") && transform.position.y < 1)
                rb.AddForce(Vector2.up * Power * 100);                                  //jump player
            if (Input.GetKeyDown("down"))                                               //squad player
            {
                Body.transform.position = new Vector3(Body.transform.position.x, Body.transform.position.y - .38f, Body.transform.position.z);
            }
            if (Input.GetKeyUp("down"))
            {
                Body.transform.position = new Vector3(Body.transform.position.x, Body.transform.position.y + .38f, Body.transform.position.z);
            }
            if (Input.GetKeyDown("space"))
            {
                Instantiate(Bullet, transform.position, Quaternion.identity);           //shoot of player

            }
            Legs.GetComponent<Animation>().Play();
        }
        else
        {
            Legs.GetComponent<Animation>().Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")                                               //death of player
        {
            rb.Sleep();
            GameOver.GetComponent<SpriteRenderer>().enabled = true;
            PressReturn.GetComponent<SpriteRenderer>().enabled = true;
            Restart.GetComponent<SpriteRenderer>().enabled = true;
        }
            
    }
}
