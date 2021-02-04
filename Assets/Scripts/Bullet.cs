using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate ( 0, 0, 1440 * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "PlayerBullet" || col.gameObject.tag == "EnemyBullet")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag != "Wall" && col.gameObject.name != "Player" && col.gameObject.name != "Bot")
        {
            Destroy(gameObject);
        }
    }
}
