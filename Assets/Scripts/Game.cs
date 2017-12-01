using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public GameObject PressReturn;
    public GameObject GameOver;
    public GameObject Restart;
    public GameObject Player;
    public GameObject Platform;
    private Rigidbody2D rb;
    public GameObject Respawn;
    public Transform Body;
    public float startSpeed;
	// Use this for initialization
	void Start () {
        rb = Player.GetComponent<Rigidbody2D>();
        PressReturn.GetComponent<SpriteRenderer>().enabled = true;
        startSpeed = Platform.GetComponent<PlatformMove>().Speed;
    }
	
	// Update is called once per frame
	void Update () {
        if (PressReturn.GetComponent<SpriteRenderer>().enabled == true)
            rb.Sleep();
        if (Input.GetKeyDown("return"))                                                     //start the game by clicking on enter
        {
            GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");
            for (int i = 0; i < platforms.Length; i++)
                Destroy(platforms[i]);
            Player.transform.position = Respawn.transform.position;
            Body.transform.position = Respawn.transform.position;
            rb.WakeUp();
            Instantiate(Platform);
            PressReturn.GetComponent<SpriteRenderer>().enabled = false;
            GameOver.GetComponent<SpriteRenderer>().enabled = false;
            Restart.GetComponent<SpriteRenderer>().enabled = false;
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < enemies.Length; i++)
                Destroy(enemies[i]);
        }
	}
}
