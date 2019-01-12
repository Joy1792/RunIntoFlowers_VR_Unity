using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacterDance : MonoBehaviour
{
    public float interval;
    public GameObject guy;
    public GameObject woman;
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
        Instantiate(woman, new Vector3(x, y, z), Quaternion.Euler(new Vector3(rotx, roty, 0)));
        Instantiate(guy, new Vector3(x, y, z), Quaternion.Euler(new Vector3(rotx, roty, 0)));
    }


}
