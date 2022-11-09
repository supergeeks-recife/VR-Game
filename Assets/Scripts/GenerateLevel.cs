using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    //Variáveis
    public GameObject[] objetos;
    public int min;
    public int max;
    public float distanceFromSpawn;
    public float spawnInterval;
    private int maxCount;
    private int count = 0;

    private GameObject randomObject;

    void Start()
    {
        maxCount = Random.Range(min, max);

        if(spawnInterval == 0)
        {
            for(int i = 0; i < maxCount; i++)
            {
                SpawnObjects();
            }
        }
        else
        {
            InvokeRepeating("SpawnObjects", 0, spawnInterval);
        }
    }

    void Update()
    {
        if(count >= maxCount)
        {
            CancelInvoke();
        }
    }

    public void SpawnObjects()
    {
        int index = Random.Range(0, objetos.Length);

        randomObject = Instantiate(objetos[index]);
        randomObject.transform.parent = transform;

        float xpos = Random.Range(transform.position.x - distanceFromSpawn, transform.position.x + distanceFromSpawn);
        float zpos = Random.Range(transform.position.z - distanceFromSpawn, transform.position.z + distanceFromSpawn);

        randomObject.transform.localPosition = new Vector3(xpos, 1f, zpos);

        count++;
    }
}
