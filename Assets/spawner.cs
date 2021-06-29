using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnrate = 0.7f;

    public GameObject hexagonPrefab; 

    private float nextTimeToSpawn = 0f; 

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
           Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
           nextTimeToSpawn = Time.time + 0.9f / spawnrate;
        }
    }
}
