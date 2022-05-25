using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    //private GameObject Car;
    public GameObject[] cars;
    public float spawnRate = 0.5f;
    private float spawnTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnCar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            SpawnCar();
            spawnTime = Time.time + spawnRate;
        }
        
    }

    private void SpawnCar()
    {
        GameObject Car = cars[UnityEngine.Random.Range(0, cars.Length)];
        Instantiate(Car, gameObject.transform.position, gameObject.transform.rotation);
    }
}
