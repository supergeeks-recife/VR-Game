using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{
    public GameObject[] objetos;//lista
    public int min;
    public int max;

    public float distance;
    private GameObject randomObject;

    void Start()
    {
        SpawnObjects();
    }

    void Update()
    {
        
    }

    public void SpawnObjects()
    {
        int indice = Random.Range(0, objetos.Length);

        randomObject = Instantiate(objetos[indice]);
        //Torna o objeto filho do spawner
        randomObject.transform.parent = transform;

        float xpos = Random.Range(transform.position.x - distance, transform.position.x + distance);
        float zpos = Random.Range(transform.position.z - distance, transform.position.z + distance);

        randomObject.transform.localPosition = new Vector3(xpos, 1, zpos);
    }
}
