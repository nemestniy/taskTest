using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour {

    public Transform Platform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform") {
            Instantiate(Platform, new Vector3(10.6f, -1.11f, 0f), Quaternion.identity);
        }
    }
}
