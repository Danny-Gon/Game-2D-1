using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public int x;
    public int y;
    public float speed;
    public bool canMove;

    private void Awake()
    {
        canMove = true;
    }

    private void Update()
    {
        int moveX = (int) Input.GetAxisRaw("Horizontal");
        int moveY = (int)Input.GetAxisRaw("Vertical");
        if (moveX != 0 && canMove)
        {
            x += moveX;
            canMove = false;
        }
        if (moveY != 0 && canMove)
        {
            y += moveY;
            canMove = false;
        }

        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);

        if(currentPosition == CalcularDireccion(x, y))
        {
            canMove = true;
        } 
    }


    private void FixedUpdate()
    {
        Vector2 finalPosition = CalcularDireccion(x,y);
        float velocity = Time.deltaTime * speed;
        transform.position = Vector2.MoveTowards(transform.position, finalPosition, speed);
          
    }

    Vector2 CalcularDireccion(int X, int Y)
    {
        return new Vector2(X + 0.5f, Y + 0.5f);
    }
}
