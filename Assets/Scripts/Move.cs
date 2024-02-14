using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField] private BoxCollider2D colSword;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spritePlayer;
    private float posColX = 1;
    private float posColY = 0;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        spritePlayer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
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
            colSword.offset = new Vector2(posColX, posColY);
            spritePlayer.flipX = false;
        }
        else if (horizontal < 0)
        {
            colSword.offset = new Vector2(-posColX, posColY);
            spritePlayer.flipX = true;
        }
    }
    
}
