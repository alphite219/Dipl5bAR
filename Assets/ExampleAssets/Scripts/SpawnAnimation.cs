using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimation : MonoBehaviour
{
    float degreesPerSecond = 530;
    float degreesSpun = 0;
    Vector3 scalePerSecond = new Vector3( 1f,1f,1f);
    Vector3 scaleIncreased = new Vector3(0, 0, 0);

    void Start()
    {
        transform.localScale = (new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(degreesSpun < 539)
        {
            transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
            degreesSpun += (degreesPerSecond *  Time.deltaTime);
            Debug.Log(degreesSpun);
        }
        else
        {
            //transform.rotation = Quaternion.Euler(new Vector3(0,540,0));
        }

        if (transform.localScale.x < 0.99)
        {
            transform.localScale += (scalePerSecond * Time.deltaTime);
            Debug.Log(transform.localScale.x);
        }
        else
        {
            transform.localScale = (new Vector3(1, 1, 1));
        }
    }
}
