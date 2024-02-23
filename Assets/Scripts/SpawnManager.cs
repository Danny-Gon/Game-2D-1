using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
    public int spawnCount = 10; //Contador de rondas
    public float timeBetweenRounds = 5f;

    private int spawnT = 0; //Ronda actual
    //private bool spawning = false;

    /*private void Start()
    {
        StartCoroutine(SpawnRounds());
    }

    private IEnumerator SpawnRounds()
    {
        spawning = true;
        Debug.Log("Comenzando ronda " + (spawnT + 1));

        foreach (Transform spawnPoint in spawnPoints)
        {
            for (int numero = 1; numero <= 2; numero++)
            {
                float numeroRandomX = Random.Range(0f, 0.8f);
                float numeroRandomY = Random.Range(0f, 0.8f);

                Vector3 offset = new Vector3(numeroRandomX, numeroRandomY, 0);

                GameObject enemigo = Instantiate(enemy, spawnPoint);

                enemigo.name = "Enemigo: " + (spawnT + 1) + "-" + numero;
                enemigo.transform.position = enemigo.transform.position + offset;
            }
        }

        yield return new WaitForSeconds(timeBetweenRounds);
        spawnT++;
    }

}*/
    private void Update()
    {
        
        if(spawnT < spawnCount)
        {
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
            spawnT++;
        }        
    }

    private void LateUpdate()
    {
        spawnT = spawnCount;
        //spawning = false;
    }

}
