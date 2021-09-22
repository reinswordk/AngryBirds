using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owl : Bird
{
    public int a = 2;
    public GameObject explotionPredab;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            if(a == 2)
            {
                Instantiate(explotionPredab, transform.position, transform.rotation);
                Destroy(other.gameObject);
                a-= 2;
            }else
            {
                return;
            }
            
        }
    }

}
