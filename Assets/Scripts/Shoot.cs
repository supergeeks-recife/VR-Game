using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Atirar();
        }
    }

    public void Atirar()
    {
        GameObject createdBullet = Instantiate(bullet);
        createdBullet.transform.position = transform.position;

        Rigidbody bullet_rig = createdBullet.GetComponent<Rigidbody>();
        Camera cam = GetComponentInChildren<Camera>();

        bullet_rig.velocity = cam.transform.rotation * Vector3.forward * bulletSpeed;
    }
}