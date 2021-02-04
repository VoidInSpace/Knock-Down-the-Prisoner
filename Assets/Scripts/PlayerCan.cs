using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "EnemyBullet")
        {
            Debug.Log("Enemy Wins");
        }
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -12.5f, -11.17f),Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);

    }
}
