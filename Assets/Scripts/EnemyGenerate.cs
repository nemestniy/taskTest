using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour {

    public Transform Enemy1;
    public Transform Enemy2;
    public Transform Enemy3;
    private float StGame = 0;
    public GameObject PressReturn;
    private Transform Enemy;
    public float lvl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PressReturn.GetComponent<SpriteRenderer>().enabled == false)
        {
            StGame += lvl * Time.deltaTime;                                     //level determination
            if (StGame > 10)
            {
                GenEnemy();
                StGame = 0;
            }
            lvl += 0.000001f;
        }
	}
    void GenEnemy ()
    {
        System.Random r = new System.Random();
        int En = r.Next(3);                                             //type of enemy determination
        switch (En)
        {
            case 0:
                Enemy = Enemy1;
                break;
            case 1:
                Enemy = Enemy2;
                break;
            case 2:
                Enemy = Enemy3;
                break;
        }
        int PosEn = r.Next(3);                                                          //place of enemy determination
        switch (PosEn)
        {
            case 0:
                Instantiate(Enemy, new Vector3(9f, 1.7f, -0.1f), Quaternion.identity);
                break;
            case 1:
                Instantiate(Enemy, new Vector3(9f, 1f, -0.1f), Quaternion.identity);
                break;
            case 2:
                Instantiate(Enemy, new Vector3(9f, 0.3f, -0.1f), Quaternion.identity);
                break;
        }
    }
}
