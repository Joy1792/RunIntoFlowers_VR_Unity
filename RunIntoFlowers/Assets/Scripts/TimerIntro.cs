using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerIntro : MonoBehaviour
{
    public float interval;
    Vector3 minscale;
    public Vector3 maxscale;
   // public Vector3 minscale;
    public bool repeatable;
    public float speed = 2.0f;
    public float duration = 5.0f;
     float nInterval = 60;

    //   void Start()
    // {
    //   Destroy(gameObject, interval);


    //}

    //}
 
    
   

    // Use this for initialization
   IEnumerator Start()
    {
        StartCoroutine(RepeatLerp(maxscale, minscale, duration));
        StartCoroutine(Death());
        {
            repeatable = true;
            // Destroy(gameObject);
            minscale = transform.localScale;
            yield return RepeatLerp(minscale, maxscale, duration);
            // yield return RepeatLerp(maxscale, minscale, duration);
            Debug.Log("fuck");
       }
    }
    
    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
        yield return new WaitForSeconds(interval);
        float i = 0.0f;
        float rate = (1f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
        

    }
    public IEnumerator Death ()
    {
        yield return new WaitForSeconds(nInterval);
        Destroy(gameObject);
    }

}


