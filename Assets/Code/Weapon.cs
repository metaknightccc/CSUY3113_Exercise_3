using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weapon : MonoBehaviour
{
    public GameObject[] loadout;
    public Transform weaponParent;
    public GameObject currentEquipment;
    public int aimSpeed = 20;
    public int damage = 5;
    public int maxAmmo = 10;
    public int currentAmmo;
    public float reloadTime = 1f;
    
    public TextMeshProUGUI ammoText;
    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
        ammoText.text = currentAmmo + "/" + maxAmmo;
        GameObject t_newEquipment = Instantiate(loadout[0], weaponParent.position, weaponParent.rotation, weaponParent) as GameObject;
        t_newEquipment.transform.localPosition = Vector3.zero;
        t_newEquipment.transform.localEulerAngles = Vector3.zero;
        currentEquipment = t_newEquipment;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            Equip(0);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            Equip(1);
        }
        Aim(Input.GetMouseButton(1));
    }

    public void Shoot()
    {
        if(currentAmmo > 0){
            currentAmmo--;
            ammoText.text = currentAmmo + "/" + maxAmmo;
        }
        else{
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        print(currentAmmo);
        ammoText.text = "RELOADING";
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        ammoText.text = currentAmmo + "/" + maxAmmo;
    }
    void Aim(bool p_isAiming)
    {
        Transform t_anchor = currentEquipment.transform.Find("Anchor");
        Transform t_state_ads = currentEquipment.transform.Find("State/ADS/Anchor");
        Transform t_state_hip = currentEquipment.transform.Find("State/Hip");
        if(p_isAiming){
            t_anchor.position = Vector3.Lerp(t_anchor.position, t_state_ads.position, Time.deltaTime * aimSpeed);
        }
        else{
            t_anchor.position = Vector3.Lerp(t_anchor.position, t_state_hip.position, Time.deltaTime * aimSpeed);            
        }
    }
    void Equip(int p_ind)
    {   
        if(currentEquipment != null){
            Destroy(currentEquipment);
        }
        GameObject t_newEquipment = Instantiate(loadout[p_ind], weaponParent.position, weaponParent.rotation, weaponParent) as GameObject;
        t_newEquipment.transform.localPosition = Vector3.zero;
        t_newEquipment.transform.localEulerAngles = Vector3.zero;
        currentEquipment = t_newEquipment;
    }
}
