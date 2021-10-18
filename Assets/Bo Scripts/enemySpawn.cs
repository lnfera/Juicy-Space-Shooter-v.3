using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject[] prefabsEnemy;
    public int wave;
    public int waveDifficultyScore;


    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void onNewWave()
    {
        wave += 1;
        waveDifficultyScore = wave * 10 + 10;
    }
}
