using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class Probarcolision : MonoBehaviour
{
    public float raycastDistance = 1f; // La distancia m�xima del rayo
    public GameObject player;
    public Transform tf;
    public Tilemap tilemap;
    public LayerMask layerMask;

    void Update()
    {
        // Definir la direcci�n y el origen del rayo
        Vector2 raycastOrigin = player.transform.position;
        Vector2 raycastDirection = Vector2.right; // Puedes ajustar la direcci�n del rayo seg�n tus necesidades

        // Realizar el Raycast
        RaycastHit2D hitInfo = Physics2D.Raycast(raycastOrigin, raycastDirection, raycastDistance,layerMask);

        if(hitInfo)
        {
            Debug.Log("entro");
            tilemap.SetTile(position, null);
            hitInfo.point;
        }
        //if (hitInfo.collider != null)
        //{
        //    Tilemap hittilemap = hitInfo.collider.GetComponent<Tilemap>();
        //    if (hittilemap != null/* && hittilemap==tilemap*/)
        //    {
        //        Debug.Log("El rayo golpe� a: ");
        //    }
        //    // Verificar si el rayo colision� con algo
           

        //    // Puedes hacer m�s con hitInfo, como obtener la posici�n de impacto (hitInfo.point), etc.
        //}
        //else
        //{
        //    // Si el rayo no golpe� nada
        //    Debug.Log("El rayo no golpe� nada.");
        //}
    }
    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object  
        Gizmos.color = Color.red;
        //Vector3 direction = tf.TransformDirection(Vector3.down) * 1;
        //Vector3 direction2 = tf.TransformDirection(Vector3.up) * 1;
        Vector3 direction3 = tf.TransformDirection(Vector3.right) * 1;
        //Vector3 direction4 = tf.TransformDirection(Vector3.left) * 1;
        //Gizmos.DrawRay(tf.position, direction);
        //Gizmos.DrawRay(tf.position, direction2);
        Gizmos.DrawRay(tf.position, direction3);
        //Gizmos.DrawRay(tf.position, direction4);
    }
}
