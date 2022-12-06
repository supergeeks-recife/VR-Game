﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Car;
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        Car.transform.rotation = Camera.main.transform.rotation;
    }
}
