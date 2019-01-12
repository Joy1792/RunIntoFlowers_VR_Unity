using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingWomanD : MonoBehaviour
{
    public float dSpeed;
    public float bSpeed;
    Rigidbody u_rb;
    float fSpeed = 100;
    public GameObject them;



    // Use this for initialization
    void Start()
    {
        // u_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //  u_rb.velocity = gameObject.transform.up * uSpeed;
        transform.position += Vector3.up * Time.deltaTime * dSpeed;
        if (them.gameObject.transform.position.y >= -6.5)
        {
            transform.position += Vector3.back * Time.deltaTime * bSpeed;
          //  transform.position += Vector3.up * Time.deltaTime * bSpeed;
        }
        if (them.gameObject.transform.position.x >= 280)
        {
            Destroy(them);
        }
    }
}
