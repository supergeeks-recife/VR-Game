using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objeto;
    public Transform[] spawnPointList;

    void Start()
    {
        int index = Random.Range(0, spawnPointList.Length);
        Instantiate(objeto, spawnPointList[index]);
    }


    void Update()
    {
        
    }
}
