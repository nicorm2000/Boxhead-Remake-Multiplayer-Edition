using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject EnemyToSpawn;
    private List <SpawneableEntity> entities = null;
    [SerializeField] private Transform conteiner;
    [SerializeField] private bool spawnEnabled;
    private Timer spawnTimer;

    void SpawnEnemiy()
    {
        GameObject GOenemy = Instantiate(EnemyToSpawn,this.transform.position,Quaternion.identity,conteiner);
        SpawneableEntity spawneable = GOenemy.AddComponent<SpawneableEntity>();
        entities.Add(spawneable);
    }

    private void Start()
    {
        entities = new List<SpawneableEntity>();
        spawnTimer = new Timer();
    }
    private void Update()
    {
        if (!spawnEnabled) return;

        spawnTimer.Update();

        if (!IsAllEnemyesDeath()) return;

        spawnTimer.Start(0.5f, SpawnEnemiy, 4);

    }

    public bool IsAllEnemyesDeath()
    {
        return SpawneableEntity.cuantity <= 0;
    }
    
}
