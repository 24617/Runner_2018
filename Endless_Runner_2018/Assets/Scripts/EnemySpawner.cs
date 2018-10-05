using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject[] Enemies;
    private List<float> Lanes = new List<float>();

    private float SpawnTimer = 5.0f;
    public float timer = 0.0f;

    void Start()
    {
        Lanes.Add(-3.5f);
        Lanes.Add(-2f);
        Lanes.Add(-0.5f);
        Lanes.Add(1f);

    }

    void Update () {
        timer += Time.deltaTime;

        if (timer >= SpawnTimer)
        {
            SpawnEnemy();
            timer = 0.0f;
        }
    }

    private void SpawnEnemy()
    {
        int RandomLane = Random.Range(0, Lanes.Capacity);
        int RandomEnemy = Random.Range(0, Enemies.Length);

        Vector3 spawnPosition = new Vector3(transform.position.x, 2, Lanes[RandomLane]);

        Instantiate(Enemies[RandomEnemy], spawnPosition, Quaternion.identity);

   
    }
}
