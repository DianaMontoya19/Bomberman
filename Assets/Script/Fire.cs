using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Fire : MonoBehaviour
{
    private  Animator Reapear;
    private bool deth = false;
    public void Start()
    {
        Reapear=GetComponent<Animator>();
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            Reapear.SetTrigger("Died");
            //Debug.Log("colsiono");

        }
    }

}
