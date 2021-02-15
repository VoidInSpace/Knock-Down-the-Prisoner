using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            Debug.Log("Player Wins");
        }
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 18.5f, 19.5f),Mathf.Clamp(transform.position.y, -5f, 5f), transform.position.z);
    }
}
