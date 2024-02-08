using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]private float speed;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spritePlayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        spritePlayer = GetComponentInChildren<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal, vertical) * speed;
        animator.SetFloat("Walk", Mathf.Abs(rb.velocity.magnitude));

        if (horizontal > 0)
        {
            spritePlayer.flipX = false;
        }
        else if (horizontal < 0)
        {
            spritePlayer.flipX = true;
        }
    }
}
