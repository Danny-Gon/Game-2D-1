using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [Header("Player")]
    public string playerName;

    [Header("Stats")]
    public int health;
    public float speed;
    public bool isAlive;

    void Start()
    {
        print("Player");
        print("Health: " +  health);
    }
}
