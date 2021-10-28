using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    // this abomination was made by me - Bo
    public GameObject[] prefabsEnemy; //  lista på alla enemy typer rang årnad efter svårighets grad -Bo
    public int wave;
    public int waveSpawnScore; // hur många poäng av enemys som är kvar i waven -Bo
    int selctedEnemy;
    public float timeBetweenSpawns; // tid imellan spawns - Bo
    public float cdSpawn; // tid till nästa enemy spans - Bo
    public Transform[] spawnPoints; // två som enemys spawns imellan - Bo



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
        if (waveSpawnScore <= prefabsEnemy.Length)
        {
            selctedEnemy = Random.Range(1, waveSpawnScore);
        }
        else
        {
            selctedEnemy = Random.Range(1, prefabsEnemy.Length);
        }
        print("selctedEnemy" + selctedEnemy);
        waveSpawnScore -= selctedEnemy;

        Instantiate(prefabsEnemy[selctedEnemy -1], new Vector3(Random.Range(spawnPoints[0].position.x, spawnPoints[1].position.x), Random.Range(spawnPoints[0].position.y, spawnPoints[1].position.y), Random.Range(spawnPoints[0].position.z, spawnPoints[1].position.z)), Quaternion.identity); // jag vet, låt mig va - Bo
        if (waveSpawnScore <= 0)
        {
            NewWave();
        }
    }
}
