using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float raycastDist = 25;
    public LayerMask enemyLayer;
    public Transform camTrans;
    public GameObject theBlood;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if(Physics.Raycast(camTrans.position, camTrans.forward, out hit, raycastDist, enemyLayer)){
                GameObject enemy = hit.collider.gameObject;
                if (enemy.CompareTag("Zombie")){
                    Instantiate(theBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    enemy.GetComponent<EnemyController>().TakeDamage(5);
                }
            }
        }
        
    }
}
