using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PowerUp : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject Box;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("powerUp"))
        {
            Destroy(tilemap.gameObject);

            Box.SetActive(false);

            Invoke("active", 2f);


        }
    }

    void active()
    {
        Box.SetActive(true);
    }
}
