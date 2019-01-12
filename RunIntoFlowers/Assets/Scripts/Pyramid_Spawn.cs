using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyramid_Spawn : MonoBehaviour
{
    public float interval;
    public float d_time;
    public GameObject pyramid;
    public float x;
    public float y;
    public float z;
    public float roty;
    public bool canCreate;
    public float rotx;
    public float InstantiationTimer = .3f;
    public GameObject spawn;
    


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= interval)
        {
            CreatePrefab();
        }
        if (Time.time >= d_time)
        {
            Destroy(spawn);
            
        }
    }
    
    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            Instantiate(pyramid, new Vector3 (x,y,z), Quaternion.Euler(new Vector3(rotx, roty, 0)));
            InstantiationTimer = .3f;
        }
    }
}
