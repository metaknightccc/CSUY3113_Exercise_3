using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_health_pickups : MonoBehaviour
{
    // spawn HealthPickUp prefabs at random locations within the bounds of the Ground object
    public GameObject HealthPickUp;
    public GameObject Ground;
    public int numHealthPickUps = 10;

    void Start()
    {
        for (int i = 0; i < numHealthPickUps; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-Ground.transform.localScale.x / 2, Ground.transform.localScale.x / 2), 0.5f, Random.Range(-Ground.transform.localScale.z / 2, Ground.transform.localScale.z / 2));
            Instantiate(HealthPickUp, pos, Quaternion.identity);
        }
    }

}
