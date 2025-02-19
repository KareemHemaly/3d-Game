﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseForCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public float speedH = 0.5f;
    public float speedV = 0.5f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        transform.localEulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
