using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PowerUp : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject Box;

    // Este bloque de codigo permite colisionar con un tilemap, cuando esto suceda me desactive el gameobject box, 
    // es un poder para lograr ver donde se encuentra la llave y la puerta.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("powerUp"))
        {
            Destroy(tilemap.gameObject);

            Box.SetActive(false);

            Invoke("active", 2f);


        }
    }
    // esta funcion se hace para poder usar el invoke, para hacer una especie de delay;
    // este funcion me permite activar de nuevo el gameobject box
    void active()
    {
        Box.SetActive(true);
    }
}
