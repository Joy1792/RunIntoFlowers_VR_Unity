using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyramid_Moving : MonoBehaviour
{
    public float dSpeed;
    public float lSpeed;
    public float bSpeed;
    //public GameObject them;



    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {

        
        transform.position += Vector3.down * Time.deltaTime * dSpeed;
        transform.position += Vector3.left * Time.deltaTime * lSpeed;
        transform.position += Vector3.back * Time.deltaTime * bSpeed;
       if (gameObject.transform.position.y <= -200 || gameObject.transform.position.y >= 500 || gameObject.transform.position.z <= -175)
        {
            Destroy(gameObject);
        }
    }
}
