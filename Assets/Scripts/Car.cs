using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float mouseX, mouseY;
    void Start()
    {
        
    }

    
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(mouseX, mouseY, 0);
    }
}
