using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class Bomb : MonoBehaviour
{
    public GameObject Player;
    public GameObject bomb;
    public Image imagen;
    public DestroyBlock Block;
   
    //public Transform tf;


    private void Start()
    {
       //Deteccion=GetComponent<Fire>();    
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Vector3 pos = Player.transform.position;

         
            GameObject NewObject = Instantiate(bomb, pos , Quaternion.identity);
            

            
            Invoke("activar", 3f);
            Invoke("desactivar", 3.5f);
           

            transform.position = NewObject.transform.position;
           

        }

       

    }
  
    //void OnDrawGizmosSelected()
    //{
    //    // Draws a 5 unit long red line in front of the object  
    //    Gizmos.color = Color.red;
    //    Vector3 direction = tf.TransformDirection(Vector3.right) * 1;
    //    Gizmos.DrawRay(tf.position, direction);
    //}

    public void activar()
    {
        imagen.gameObject.SetActive(true);
        Block.enabled = true;
       
    }
    public void desactivar()
    {
        imagen.gameObject.SetActive(false);
        Block.enabled = false;
    }

}
