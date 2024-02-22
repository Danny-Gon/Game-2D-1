using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField] private BoxCollider2D colSword;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spritePlayer;
    private float posColX = 1;
    private float posColY = 0;

    private int life = 3;
    [SerializeField] UIManager uiManager;
    
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
        if (Input.GetKeyDown(KeyCode.K))
        {
            Damage();
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

    public void Damage()
    {
        if(life > 0)
        {
            life--;
            uiManager.RestaLife(life);

            if (life == 0)
            {
                animator.SetTrigger("Dead");
                Invoke(nameof(Dead), 1.5f);
            }
        }
    }

    private void Dead()
    {
        Destroy(this.gameObject);
    }

}
