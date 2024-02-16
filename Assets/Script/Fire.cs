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
    
    public void Start()
    {
        Reapear = GetComponent<Animator>();
        
       

    }

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
                    

        //if(pl1 ==false&& pl2==false)
        //{
        //    Debug.Log("gameOver");
        //}

    


            
        
    }

}
