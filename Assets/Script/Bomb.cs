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
    public GameObject fire;
    public DestroyBlock Block;
    public string PL;


    //public Transform tf;


    private void Start()
    {
       //Deteccion=GetComponent<Fire>();    
    }

    void Update()
    {

        //float Enter = Input.GetAxis(PL);

        //if()
        //{

        //}
        
  

        if (Input.GetKeyDown(PL))
        {

            Vector3 pos = Player.transform.position;

         
            GameObject Pl1 = Instantiate(bomb, pos , Quaternion.identity);

            //activar();
            
            Invoke("activar", 3f);
            Invoke("desactivar", 5f);
           

            transform.position = Pl1.transform.position;
 
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
        fire.gameObject.SetActive(true);
        Invoke("block", 0.5f);
        
       
    }
    public void desactivar()
    {
        
        fire.gameObject.SetActive(false);
        Block.enabled = false;
    }
    public void block()
    {
        Block.enabled = true;
    }

}
