using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public BoxCollider2D colSword;

    private void Awake()
    {
        colSword = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if(otro.CompareTag("Zombie"))
        {
            Debug.Log("Hit");
            Destroy(otro.gameObject);
        }
    }
}
