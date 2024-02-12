using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class Keyanddoor : MonoBehaviour
{
    public string Key;
    public string Door;
    public Tilemap[] tilemap;
    public bool llave = false;
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Key))
        {
            Destroy(tilemap[0].gameObject);
            Debug.Log("LLave Reclamada");
            llave = true;


        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag(Door))
        {
            Debug.Log("Encuentra la llave para abrir la puerta");
            if (llave)
            {
                Destroy(tilemap[1].gameObject);
                Debug.Log("Puerta Abierta");
            }
        }
     }
}
