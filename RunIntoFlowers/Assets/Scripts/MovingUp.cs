using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUp : MonoBehaviour {
    public float uSpeed;
    Rigidbody u_rb;

    

	// Use this for initialization
	void Start () {
       // u_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //  u_rb.velocity = gameObject.transform.up * uSpeed;
        transform.position += Vector3.up * Time.deltaTime;
    }
}
