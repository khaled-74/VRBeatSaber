using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] cubeType;
    public Transform[] spawnPos;

    public float startDelay = 2;
    public float spawnInterval = 3f;

    public GameObject hand;
    private void Start()
    {
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }
    private void Update()
    {

    }
    void SpawnRandomCube() 
    {
        int cubeIndex = Random.Range(0, cubeType.Length);
        int posIndex = Random.Range(0, spawnPos.Length);
        Instantiate(cubeType[cubeIndex], spawnPos[posIndex].position, cubeType[cubeIndex].transform.rotation);
    }

}
