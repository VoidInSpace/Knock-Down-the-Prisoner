using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCan : MonoBehaviour
{
    public GameObject playerPopup;
    
    private void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "EnemyBullet")
        {
            playerPopup.SetActive(true);
            StartCoroutine(DelayClose());
        }
    }

    void Update()
    {
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -19.5f, -18.5f),Mathf.Clamp(transform.position.y, -5f, 5f), transform.position.z);
    }

    private IEnumerator DelayClose()
    {
        yield return new WaitForSeconds(1f);
        playerPopup.SetActive(false);
    }
}
