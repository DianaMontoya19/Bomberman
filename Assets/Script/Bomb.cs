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


    void Update()
    {
        // Si presiono la tecla especidica de cada jugador, player1 usa enter, player2 usa esc.
        // si la presiona me crea una bomba.

        if (Input.GetKeyDown(PL))
        {

            Vector3 pos = Player.transform.position;

         
            GameObject Pl1 = Instantiate(bomb, pos , Quaternion.identity);

            
            
            Invoke("activar", 3f);
            Invoke("desactivar", 5f);
           

            transform.position = Pl1.transform.position;
 
        }
 


    }

    // se usa para activar la explosion, solo se hace la funcion para usar el invoke, arriba y poder hacer que se active justo despues
    // de que la animcaion de la bomba acabe.
    public void activar()
    {
        fire.gameObject.SetActive(true);
       

        Invoke("block", 0.5f);
        
       
    }
    // se usa para el invoke, me desactiva el script donde se me elimina el bloque, y luego en la siguiente funcion block me lo vuelve a activar
    // esto con el fin de que el bloque se me destruya al tiempo en que el fuego sale.
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
