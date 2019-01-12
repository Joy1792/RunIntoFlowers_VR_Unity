using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDeath : MonoBehaviour
{

    



    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.position.y >= 40 || gameObject.transform.position.y <= -40)
        {
            Destroy(gameObject);
        }


    }
}

