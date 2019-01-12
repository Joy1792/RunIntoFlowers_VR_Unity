using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralCube_Spawn : MonoBehaviour
{
    public float interval;
    public GameObject s_cubes;
    public float x;
    public float y;
    public float z;
    public float roty;
    public bool canCreate;
    public float rotx;
    public float dTime;




    // Update is called once per frame
    void Update()
    {

        if (canCreate == false)
        {
            {
                StartCoroutine(WaitSeconds(interval));
                canCreate = true;

            }
        }


    }

    IEnumerator WaitSeconds(float interval)
    {
        yield return new WaitForSeconds(interval);
        Instantiate(s_cubes, new Vector3(x, y, z), Quaternion.Euler(new Vector3(rotx, roty, 0)));

    }


}
