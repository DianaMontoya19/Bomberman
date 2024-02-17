using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class Keyanddoor : MonoBehaviour
{
    public string Key;
    public string Door;
    public string Win;
    public Tilemap[] tilemap;
    public bool llave = false;

    //Al colisionar con la llave, que tiene diferente nombre para cada jugador, la llave me la destruye.
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Key))
        {
            Destroy(tilemap[0].gameObject);
            Debug.Log("LLave Reclamada");
            llave = true;


        }
    }

    // Si recogio la llave y colisiona con la puerta puede entrar, pero solo cuando se recolecte la llave.
    // luego me cambia la escena y me dice que jugador gano.
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag(Door))
        {
            Debug.Log("Encuentra la llave para abrir la puerta");
            if (llave)
            {
                Destroy(tilemap[1].gameObject);
                Time.timeScale = 0f;
                SceneManager.LoadScene(Win);
                Debug.Log("Puerta Abierta");
            }
        }
     }
}
