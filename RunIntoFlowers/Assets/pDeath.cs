using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pDeath : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {


        
        if ( gameObject.transform.position.z <= -70)
        {
            Destroy(gameObject);
        }
    }
}
