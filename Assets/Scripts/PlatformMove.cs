using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

    public float Speed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
            transform.position = new Vector3(transform.position.x - Speed, transform.position.y, transform.position.z);

	}
}
