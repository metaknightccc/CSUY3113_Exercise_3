using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] SpawnLocations;
    public GameObject[] SpawnPrefab;
    

    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start(){
        InvokeRepeating("StartSpawn", spawnTime, spawnDelay);
    }

    void StartSpawn(){
        Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, transform.rotation);
        Instantiate(SpawnPrefab[1], SpawnLocations[1].transform.position, transform.rotation);
        Instantiate(SpawnPrefab[2], SpawnLocations[2].transform.position, transform.rotation);
        if(stopSpawning){
            CancelInvoke("StartSpawn");
        }
    }
}
