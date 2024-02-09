using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    private BoxCollider2D colSword;
    public static Animator SwordAnim;

    // SwordAttack.SwordAnim

    private void Awake()
    {
        colSword = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Zombie"))
        {
            Destroy(otro.gameObject);
        }
    }
}
