using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    [Header("Spawn in Animals")]
    [SerializeField] GameObject[] animals;
    [SerializeField] float spawnRangeX = 10;
    [SerializeField] float spawnPosZ = 20;

    [Header("Spawn Time")]
    [SerializeField] float startDelay = 2;
    [SerializeField] float spawnInterval = 1.5f;

    // Update is called once per frame
    void Start() {
        this.InvokeRepeating("SpawnRandomAnimal", this.startDelay, this.spawnInterval);
    }

    void SpawnRandomAnimal() {
        // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-this.spawnRangeX, this.spawnRangeX),
            0, this.spawnPosZ);
            
        // Spawn in the animals and pick a random one out            
        int animalIndex = Random.Range(0, this.animals.Length);

        Instantiate(this.animals[animalIndex], spawnPos,
            this.animals[animalIndex].transform.rotation);
    }
}
