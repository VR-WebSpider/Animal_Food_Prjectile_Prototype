using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //To make arrey variable we put [] next to the variable
    public GameObject[] animalPrefabs;
    //Below tow veriables will be used to create a new local variable in if statement of "Vector3 spawnPos"
    private float spawnRangeX = 20; //This variable is X asis range for spawning
    private float spawnPosZ = 20; //This veriable is position on Z asix for spawning

    //Creating variables for delay and interval
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Using new method to auto spawn 
        //InvokeRepeating("SpawnRandomAnimal", 2, 1.5f); //here 2 is Delay to interval from start and 1.5 is interval to spawn after delay of 2 second

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); //Using variables for delay and interval of spawning
    }

    // Update is called once per frame
    void Update()
    {
        //Removing if statement to use new method "InvokeRepeating"
        //if (Input.GetKeyDown(KeyCode.S))
        //Random.Range picks random GameObjects from arrey
        {
            //(0, 3) means it will pick from 0 to 2 from animalIndex arrey
            //int animalIndex = Random.Range(0, 3);
            //int animalIndex = Random.Range(0, animalPrefabs.Length); //Creating local variable, "animalprefab.lenth" will also pick 0 to last arrey

            //Creating new local variable for spawn range and position using globle variables
            //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            //new vector3 (0, 0, 20) picks spawner location and animalprefabs[animalIndex].transform.rotation picks spawner rotation
            //Instantiate(animalPrefabs[animalIndex], new Vector3 (0, 0, 20), animalPrefabs[animalIndex].transform.rotation);

            //Replcing X value in new Vector3 (0, 0, 20) to Random.Range(-20, 20) to spawn in X direction brtween -20 to 20
            //Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-20, 20), 0, 20), animalPrefabs[animalIndex].transform.rotation);

            //Updating this above line "new Vector3(Random.Range(-20, 20), 0, 20)" to "spawnPosZ"
            //Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);


            //SpawnRandomAnimal();
        }
    }
    //Creating new function "SpawnRandomAnimal" and write it in if statement to make script short, whenever we call it, it calls scripts under it
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
