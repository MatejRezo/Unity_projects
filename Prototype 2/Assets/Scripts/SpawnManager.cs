using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 58;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomAnimal()
    {
         float xAxsis = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition =  new Vector3(xAxsis, 0, spawnRangeZ);
             int animalIndex = Random.Range (0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation); 
    }
}
