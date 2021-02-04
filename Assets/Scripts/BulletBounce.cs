using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBounce : MonoBehaviour
{
    public Rigidbody2D rb;

    Vector3 lastVelocity;

    private void Awake() 
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D coll) 
    {
        if (coll.gameObject.tag == "Wall")
        {
            var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
        }
    }
}
