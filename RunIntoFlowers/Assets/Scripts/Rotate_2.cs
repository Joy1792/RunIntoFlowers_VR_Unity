using UnityEngine;
using System.Collections;

public class Rotate_2 : MonoBehaviour
{
    public float speed = 20;
    float nspeed = 100;
    Vector3 minscale = new Vector3 (0,0,0);
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
        if (gameObject.transform.localScale == minscale)
        {
            transform.RotateAround(Vector3.zero, Vector3.right, nspeed * Time.deltaTime);
        }
    }
    
}