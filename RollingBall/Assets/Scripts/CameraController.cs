﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }
    
    void LateUpdate()
    {
        this.transform.position = player.transform.position + offset;
    }
}
