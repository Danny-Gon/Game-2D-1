using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private SpriteRenderer sprite;
    private Transform objetivo;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        
       
    }
        
    private void Update()
    {
        agent.SetDestination(player.position);
        objetivo = player;
        RotarZombie();
    }

    void RotarZombie()
    {
        if (this.transform.position.x > objetivo.position.x)
        {
            sprite.flipX = true;
            //transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            sprite.flipX = false;
            //transform.localScale = new Vector2(1, 1);
        }
    }
}
