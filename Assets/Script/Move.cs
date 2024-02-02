using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Move : MonoBehaviour
{
    public GameObject Player;
    public float speed = 1f;
    private Rigidbody2D rb;
 
    public Transform tf;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
      

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");

      
        Vector2 Move = new Vector2(MoveX * speed, MoveY * speed);
        rb.velocity = Move * speed;
        rb.gravityScale = 0f;


    }

}
