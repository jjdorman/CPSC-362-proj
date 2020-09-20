﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

     public GameObject enemy;
     float randX;
     Vector2 whereToSpawn;
     public float spawnRate = 2f;
     float nextSpawn = 0.0f;
   

     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
          {
               nextSpawn = Time.time + spawnRate;
               randX = UnityEngine.Random.Range(-8.4f, 8.4f);
               whereToSpawn = new Vector2(transform.position.x, transform.position.y);
               Instantiate(enemy, whereToSpawn, Quaternion.identity);
          }


    }
}
