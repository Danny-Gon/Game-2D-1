using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
       

    private void Start()
    {
        print("Spawn Enemy");
        
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(enemy, spawnPoint);
        }
    }
}
