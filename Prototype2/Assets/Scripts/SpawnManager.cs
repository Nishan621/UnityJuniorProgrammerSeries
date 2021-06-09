using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] animalPrefabs;
  private float spawnRangeX = 20.0f;
  private float spawnPosZ = 20.0f;
  private float spawnPosX = 30.0f;
  private float startDelayTop = 2.0f;
  private float startDelayRight = 3.0f;
  private float startDelayLeft = 4.0f;
  private float spawnInterval = 4.0f;


  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("SpawnRandomAnimalTop", startDelayTop, spawnInterval);
    InvokeRepeating("SpawnRandomAnimalRight", startDelayRight, spawnInterval);
    InvokeRepeating("SpawnRandomAnimalLeft", startDelayLeft, spawnInterval);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void SpawnRandomAnimalTop()
  {
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnAnimals = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
    Instantiate(animalPrefabs[animalIndex], spawnAnimals, animalPrefabs[animalIndex].transform.rotation);
  }

  void SpawnRandomAnimalRight()
  {

    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnAnimals = new Vector3(spawnPosX, 0, Random.Range(5, spawnRangeX));
    Vector3 rotation = new Vector3(0, -90, 0);
    Instantiate(animalPrefabs[animalIndex], spawnAnimals, Quaternion.Euler(rotation));
  }

  void SpawnRandomAnimalLeft()
  {
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnAnimals = new Vector3(-spawnPosX, 0, Random.Range(5, spawnRangeX));
    Vector3 rotation = new Vector3(0, 90, 0);
    Instantiate(animalPrefabs[animalIndex], spawnAnimals, Quaternion.Euler(rotation));
  }
}
