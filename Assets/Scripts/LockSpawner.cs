using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSpawner : MonoBehaviour
{
    public GameObject Lock;
    float ranY;
    float ranX;
    Vector2 whereToSpawn;
    public float spawnRate;
    public float nextSpawn;

    void Start()
    {

    }


    void Update()
    {
        if (Time.timeSinceLevelLoad > nextSpawn)
        {
            nextSpawn = Time.timeSinceLevelLoad + spawnRate;
            ranY = Random.Range(-27f, -16f);
            ranX = Random.Range(-4f, 22f);
            whereToSpawn = new Vector2(ranX, ranY);

            Instantiate(Lock, whereToSpawn, Quaternion.identity);
        }
    }
}
