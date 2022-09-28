using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public Transform camTrans;
    // Start is called before the first frame update

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
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
