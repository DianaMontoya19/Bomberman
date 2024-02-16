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
    private bool pl1;
    private bool pl2;
    public void Start()
    {
        Reapear = GetComponent<Animator>();
        
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(Player)
        {
            case "Player1":
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
                       pl1= false;
                     }
                break;

            case "Player2":
                if (collision.gameObject.CompareTag("Fire2") || collision.gameObject.CompareTag("Enemy"))
                {
                    Reapear.SetTrigger("Died");

                    Heart[Count].fillAmount = 0;
                    Debug.Log("Count" + Count);
                    Count++;
                }
                if (Count >=3)
                {
                    Gamer.SetActive(false);
                    pl2 = false;
                }
                break;

        }


    


            
        
    }

}
