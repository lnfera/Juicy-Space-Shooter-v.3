using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject[] prefabsEnemy;
    public int wave;
    public int waveSpawnScore;
    int selctedEnemy;
    public float timeBetweenSpawns;
    public float cdSpawn; // cooldown mellan enemy spans 
    public 


    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        cdSpawn -= Time.fixedDeltaTime;
        if (cdSpawn < 0)
        {
            spawnEnemy();
        }
        if (waveSpawnScore <= 0)
        {
            NewWave();
        }
    }


    void Update()
    {
        
    }
    public void NewWave()
    {
        wave += 1;
        waveSpawnScore = wave * 10 + 10;
        cdSpawn = 5;
        print("new wave " + wave);
    }
    public void spawnEnemy()
    {
        cdSpawn = timeBetweenSpawns;
        if (waveSpawnScore <= 15)
        {
            selctedEnemy = Random.Range(1, waveSpawnScore);
        }
        else
        {
            selctedEnemy = Random.Range(1, prefabsEnemy.Length - 1);
        }
        print("selctedEnemy" + selctedEnemy);
        waveSpawnScore -= selctedEnemy;

        Instantiate(prefabsEnemy[selctedEnemy -1], new Vector3(0, 0, 0), Quaternion.identity);
    }
}
