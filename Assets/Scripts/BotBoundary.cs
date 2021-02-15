using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotBoundary : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 3f, 16f),Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);
    }
}
