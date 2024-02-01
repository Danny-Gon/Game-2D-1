using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Enemy")]
    public string enemyName;

    [Header("Stats")]
    public int health;
    public float speed;
    public int damage;
    public bool isAlive;

    private void Start()
    {
        print(enemyName + "ha aparecido!");
        print("Health: " + health);

    }
}
