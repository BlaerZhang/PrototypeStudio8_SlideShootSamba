using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> enemyPrefabList;
    
    [Range(0,1)] public float difficulty;

    public float timeToMaxDifficulty;

    public List<GameObject> enemyAlive;

    public float spawnCoolDown;

    private float spawnTimer;

    void Start()
    {
        spawnTimer = 0;
    }


    void Update()
    {
        difficulty = Time.timeSinceLevelLoad / timeToMaxDifficulty;
        if (difficulty > 1) difficulty = 1;
        
        enemyAlive = GameObject.FindGameObjectsWithTag("Enemy").ToList();

        int enemyMax = Mathf.RoundToInt(difficulty * 19 + 1);

        if (enemyAlive.Count < enemyMax)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            float randomNumber = Random.Range(0f, 1f);
            Vector2 randomPos = new Vector2(Random.Range(-15f, 14f), Random.Range(8f, 16f));
        
            if (randomNumber < difficulty)
            {
                Instantiate(enemyPrefabList[1], randomPos, Quaternion.Euler(new Vector3(0,0,Random.Range(0f,360f))));
            }
            else
            {
                Instantiate(enemyPrefabList[0], randomPos, Quaternion.Euler(new Vector3(0,0,Random.Range(0f,360f))));
            }
            spawnTimer = spawnCoolDown;
        }
    }
}
