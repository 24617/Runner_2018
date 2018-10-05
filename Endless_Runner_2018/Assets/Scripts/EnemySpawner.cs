using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject Snail;
    public List<float> Lanes = new List<float>();

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
        int RandomEnemy = Random.Range(0, Lanes.Capacity);

        Vector3 spawnPosition = new Vector3(transform.position.x, 2, Lanes[RandomEnemy]);

        Instantiate(Snail, spawnPosition, Quaternion.identity);

        Debug.Log(Lanes[RandomEnemy]);
    }
}
