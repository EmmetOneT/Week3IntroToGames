using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float initialSpawnTime = 2;
    public float spawnTime = 2;

    void Start()
    {
        //will call a method every X seconds, repeats forever
        InvokeRepeating("SpawnGameObject", initialSpawnTime, spawnTime);
    }

    void SpawnGameObject()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
