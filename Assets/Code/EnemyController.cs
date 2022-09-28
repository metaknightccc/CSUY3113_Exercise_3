using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public Transform camTrans;
    private GameObject player;
    public NavMeshAgent enemy;
    // Start is called before the first frame update

    void Start()
    {
        health = maxHealth;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(health > 0 ){
            enemy.SetDestination(player.transform.position);
        }
        else{
            enemy.enabled = false;
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0){
            GameObject zombie = this.gameObject;
            Rigidbody zombieRB = zombie.GetComponent<Rigidbody>();
            zombieRB.AddForce(camTrans.forward * 800 + Vector3.up * 200);
            zombieRB.AddTorque(new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50)));
        }
    }
}
