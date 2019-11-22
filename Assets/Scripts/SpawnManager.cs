using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    //dit is hoe wijd de dieren kunnen spawnen
    private float spawnRangeX = 20;

    //dit is hoe hoog de dieren altijd spawnen
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        //voer de functie SpawnRandomAnimal herhalend uit 
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnRandomAnimal(){
         //een random animal prefab
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            //een random berekende locatie
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
            
            //spawn een willekeurig animal prefab op een willekeurige locatie
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[2].transform.rotation);
    }
}
