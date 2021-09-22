using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeTime : MonoBehaviour
{
    public float LifeTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, LifeTime);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
