using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawer : MonoBehaviour
{
    public GameObject Heart;
    float ranY;
    float ranX;
    Vector2 whereToSpawn;
    public float spawnRate = 1f;
    public float nextSpawn = 1f;

    void Start()
    {

    }


    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            ranY = Random.Range(-27f, -16f);
            ranX = Random.Range(-4f, 22f);
            whereToSpawn = new Vector2(ranX, ranY);

            Instantiate(Heart, whereToSpawn, Quaternion.identity);
        }
    }
}
