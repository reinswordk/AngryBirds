using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owl : Bird
{

    [SerializeField]
    public float fieldOfImpact = 0.4f;
    public float force = 0.6f;

    public LayerMask LayerToHit;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Explode();
            //Destroy(other.gameObject);
            
        }
    }

    void Explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfImpact, LayerToHit);
        foreach(Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;;
            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
        }
    }
}
