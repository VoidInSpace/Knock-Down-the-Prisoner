using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    
    void Update()
    {
        transform.Rotate ( 0, 0, 1440 * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "PlayerBullet" || col.gameObject.tag == "EnemyBullet")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.65f);
            Destroy(gameObject);
        }
        if (col.gameObject.tag != "Wall")
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.65f);
            Destroy(gameObject);
        }
    }
}
