using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
    public int spawnCount = 10; //Contador de rondas
    public float timeBetweenRounds = 100f;

    private int spawnT = 0; //Ronda actual
    [HideInInspector] public bool spawning = false;

    private void Start()
    {
        StartCoroutine(SpawnRounds());
    }

    private void Update()
    {   
        if(spawning == true) 
        { 
        StartCoroutine(SpawnRounds());
        }
    }
    private IEnumerator SpawnRounds()
    {
        spawning = true;
        Debug.Log("Comenzando ronda " + (spawnT + 1));
       
        print("Se ha generado una oleada de enemigos");
                                   
        foreach (Transform spawnPoint in spawnPoints)
        {
            for(int indiceAuxiliar = 0; indiceAuxiliar < spawnPoint.childCount; indiceAuxiliar++)
            {
                GameObject enemyT = spawnPoint.GetChild(indiceAuxiliar).gameObject;
            }
                
            for (int numero = 1; numero <= 2; numero++)
            {
                    float numeroRandomX = Random.Range(0f, 0.8f);
                    float numeroRandomY = Random.Range(0f, 0.8f);

                    Vector3 offset = new Vector3(numeroRandomX, numeroRandomY, 0);

                    GameObject enemigo = Instantiate(enemy, spawnPoint);
                                                            
                    enemigo.name = "Enemigo: " + spawnT + "-" + numero;
                    enemigo.transform.position = enemigo.transform.position + offset;
            }
        }
        spawning = false;
        
        yield return new WaitForSeconds(timeBetweenRounds);
        spawnT++;
        spawning = true;
    }

    private void LateUpdate()
    {
        spawnT = spawnCount;
    }
}
