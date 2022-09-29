using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    private float raycastDist = 25;
    public LayerMask enemyLayer;
    public Transform camTrans;
    public GameObject theBlood;
    private Weapon currentWeapon;
    private GameObject Player;
    public Image reticle;
    private bool reticleTarget = false;

    private void Start()
    {
        Player = GameObject.Find("Player");
        currentWeapon = Player.GetComponent<Weapon>();

    }
    // Update is called once per frame
    void Update()
    {   
        if (Input.GetMouseButtonDown(0) && currentWeapon.currentEquipment != null){
            currentWeapon.Shoot();
            RaycastHit hit;
            if(Physics.Raycast(camTrans.position, camTrans.forward, out hit, raycastDist, enemyLayer)){
                GameObject enemy = hit.collider.gameObject;
                if (enemy.CompareTag("Zombie") && currentWeapon.currentAmmo > 1 && currentWeapon.currentEquipment != null){
                    Instantiate(theBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    enemy.GetComponent<EnemyController>().TakeDamage(currentWeapon.damage);
                }
            }
        }
        
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(camTrans.position, camTrans.forward, out hit, raycastDist) && 
        (hit.collider.CompareTag("Zombie"))){
            if(!reticleTarget){
                reticle.color = Color.red;
                reticleTarget = true;
            }
        }
        else if (reticleTarget){
            reticle.color = Color.white;
            reticleTarget = false;
        }
    }
}
