using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

    private Rigidbody2D rb;
    public float Force;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(Vector2.right * Force * Time.deltaTime * 1000, ForceMode2D.Impulse);    //make a shot
        if (transform.position.x > 100)
            Destroy(gameObject);                                                            //destroy a bullet
	}

}
