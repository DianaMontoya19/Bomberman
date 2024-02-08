using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class GrillMOve : MonoBehaviour
{
    public int x, y;
    public float speed = 0.025f;
    public bool canMove;
    public string MoveX;
    public string MoveY;
    private Vector2 PreviousPosition;
    public bool probar = false;

    private Rigidbody2D rb;

    void Start()
    {
        canMove = true;
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        int moveX = (int) Input.GetAxisRaw(MoveX);
        int moveY = (int) Input.GetAxisRaw(MoveY);

        if(moveX != 0 && canMove )
        {
            x += moveX;
            canMove = false;
            
        }
        if(moveY != 0 && canMove )
        {
            y += moveY;
            canMove=false;
        }

        Vector2 currentPosition = new Vector2(transform.position.x,transform.position.y);

       if(currentPosition == CalcularDireccion(x, y))
        {
            canMove = true;
            PreviousPosition = currentPosition;
        }
        Activar();

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            if (!probar)
            {
                transform.position = PreviousPosition;
                Vector2 newPosition = new Vector2(transform.position.x, transform.position.y);

                speed = 0;

                Debug.Log("entro");
                probar = true;
                canMove = true;
            }
            
        }

    }
    public void OnCollisionExit2D(Collision2D other)
    {
       
        Invoke("Activar", 5f);
        
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = CalcularDireccion(x,y);
        float velocity = speed;
        transform.position = Vector2.MoveTowards(transform.position, position, velocity);
        rb.gravityScale = 0f;
    }

    public Vector2 CalcularDireccion(int x, int y)
    {
        return new Vector2(x + 0.5f, y + 0.5f);
    }

    public void Activar()
    {
        //speed = 0.025f;
        probar = false;
        
    }

}
