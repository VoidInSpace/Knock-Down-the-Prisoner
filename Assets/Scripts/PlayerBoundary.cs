﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10.32f, -1.17f),Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);
    }
}
