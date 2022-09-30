using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Spawner : Singleton<Spawner>
{
    public Transform[] SpawnLocations;
    public GameObject[] SpawnPrefab;
    public List<EnemyController> AliveList;
    public TextMeshProUGUI waveText;
    AudioSource _audioSource;
    public AudioClip startWaveSound1;
    public AudioClip startWaveSound2;
    public AudioClip startWaveSound3;
    private void Start() {
    _audioSource = GetComponent<AudioSource>();
    }
    public void StartSpawn(int wave){
        AliveList.Clear();
        if (wave == 1)
        {
            waveText.text = wave + "/3 waves";
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[1].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
        }
        if (wave == 2)
        {   
            waveText.text = wave + "/3 waves";
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[0].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[1].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[0], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[1], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
            AliveList.Add(Instantiate(SpawnPrefab[1], SpawnLocations[2].transform.position, transform.rotation).GetComponent<EnemyController>());
        }
        if (wave == 3)
        {
            waveText.text = wave + "/3 waves";
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
