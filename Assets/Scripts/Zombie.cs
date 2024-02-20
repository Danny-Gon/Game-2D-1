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
    
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    private void Update()
    {
        agent.SetDestination(player.position);
        objetivo = player;
    }

    private void Reset()
    {
        if (this.transform.position.x > player.position.x)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }
}
