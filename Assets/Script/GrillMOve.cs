using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class GrillMOve : MonoBehaviour
{
    public int x, y;
    public float speed = 0.025f;
    public bool canMove;
    public string MoveX;
    public string MoveY;
    private Vector2 PreviousPosition;
    public bool probar = false;
    public bool up = false;
    public bool down = false;
    public bool right = false;
    public bool left = false;
    private bool enter = false;
    private Animator anim;
    public LayerMask layerMask;

    public Transform tf;

    private Rigidbody2D rb;
    

    void Start()
    {
        canMove = true;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        int moveX = (int) Input.GetAxisRaw(MoveX);
        int moveY = (int) Input.GetAxisRaw(MoveY);

       

        if (moveX != 0 && canMove )
        {
            if (moveX <= 0 && !left)
            {
                x += moveX;
                canMove = false;
                probar = true;
                
            }

            if (moveX >= 0 && !right)
            {
                    x += moveX;
                    canMove = false;
                    probar = true;
                    GetComponent<SpriteRenderer>().flipX = false;
                    
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;

            }

        }
        
        if (moveY != 0 && canMove )
        {

            if (moveY >= 0 && !up)
            {
                y += moveY;
                canMove = false;
                enter = true;
               
              

            }

            if (moveY <= 0  && !down)
            {
                y += moveY;
                canMove = false;
               
            }

        }



        Vector2 currentPosition = new Vector2(transform.position.x,transform.position.y);

       if(currentPosition == CalcularDireccion(x, y))
        {
            canMove = true;
            probar = false;
            enter = false;
           
            
            
        }
        anim.SetBool("Activar", probar);
        anim.SetBool("Subir", enter);

        anim.SetFloat("VelX", moveX);
        anim.SetFloat("VelY", moveY);

        up = Physics2D.Raycast(tf.position, Vector2.up, 0.5f, layerMask);
        down = Physics2D.Raycast(tf.position, Vector2.down, 1f,layerMask);
        right = Physics2D.Raycast(tf.position, Vector2.right, 1f, layerMask);
        left = Physics2D.Raycast(tf.position, Vector2.left, 1f, layerMask);



    }

    void FixedUpdate()
    {
        Vector2 position = CalcularDireccion(x,y);
        float velocity = speed;
        transform.position = Vector2.MoveTowards(transform.position, position, velocity);
        
        rb.gravityScale = 0f;
    }

    public Vector2 CalcularDireccion(int x, int y)
    {
        return new Vector2(x + 0.5f, y + 0.6f);
    }

}
