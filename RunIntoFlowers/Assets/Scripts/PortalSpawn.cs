using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawn : MonoBehaviour
{
    public float interval;
    public GameObject Portal;
    public float x;
    public float y;
    public float z;
    public float roty;
    public bool canCreate;
    public float rotx;


    // Update is called once per frame
    void Update()
    {
        
        if (Time.time >= interval && canCreate ==false)
        {
            canCreate = true;
            Instantiate(Portal, new Vector3(x, y, z), Quaternion.Euler(new Vector3(rotx, roty, 0)));
        }
    }

}
