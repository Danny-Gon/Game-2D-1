using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;

    private void Start()
    {
        print("Spawn Enemy");
        Instantiate(enemy,spawnPoint);
    }
}
