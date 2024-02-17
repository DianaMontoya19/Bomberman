using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    private  Animator Reapear;
    public   List<Image> Heart = new List<Image>();
    private int Count = 0;
    public string Player;
    public GameObject Gamer;
    public bool Alive = true;
    
    // me entra al componente del animator una animación que me permite poner a titilar al jugador.
    public void Start()
    {
        Reapear = GetComponent<Animator>();

    }
    // si el jugador colisiona con el fuego de la explosion o con el enemigo, me active la animacion y me reduzca la vida.
    // luego si la vida es mayor o igual a 3 entonces me descative al jugador y se muestre como si ya no existiera, para demostrar que murio.
    private void OnTriggerEnter2D(Collider2D collision)
    {

                     if (collision.gameObject.CompareTag("Fire") || collision.gameObject.CompareTag("Enemy"))
                        {
                            Reapear.SetTrigger("Died");

                            Heart[Count].fillAmount = 0;
                            Debug.Log("Count" + Count);
                            Count++;
                        }
                     if(Count>=3)
                     {
                       Gamer.SetActive(false);
                       Debug.Log("murio");
                       Alive = false;
                     }
                    



    


            
        
    }

}
