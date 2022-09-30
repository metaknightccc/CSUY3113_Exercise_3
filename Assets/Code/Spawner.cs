using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : Singleton<Spawner>
{
    public Transform[] SpawnLocations;
    public GameObject[] SpawnPrefab;
    public List<EnemyController> AliveList;

    public void StartSpawn(int wave){
        AliveList.Clear();
        if (wave == 1)
        {
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[1].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
        }
        if (wave == 2)
        {
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[1].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[1], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[1], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
        }
        if (wave == 3)
        {
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[1].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[1], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[1], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[2], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
        }
        if (wave == 4)
        {
            SceneManager.LoadScene("EndScene");
        }
        
    }
}
