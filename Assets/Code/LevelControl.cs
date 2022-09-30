using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Update = Unity.VisualScripting.Update;

public class LevelControl : MonoBehaviour
{
    [SerializeField] private Wave wave;
    void Start()
    {
        StartBattle();
    }

    private void StartBattle(){
        wave.SpawnEnemies(1);
    }
    
    public void FixedUpdate()
    {
        wave.CheckAlive();
    }
    
    [System.Serializable]
    private class Wave
    {
        private int wave_num = 1;
        public void CheckAlive()
        {
            foreach (EnemyController i in Spawner.GetInstance().AliveList)
            {
                if (i.isAlive == true) return;
            }
            SpawnEnemies(++wave_num);
        }
        
        public void SpawnEnemies(int wave_num)
        {
            Spawner.GetInstance().StartSpawn(wave_num);
        }
    }
}
