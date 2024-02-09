using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Fire : MonoBehaviour
{
    public  Animator Reapear;
    //public void Start()
    //{
    //    Reapear.enabled=false;
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Fire"))
        {
            Reapear.enabled = true;
            Invoke("stop", 3f);
        }
    }

   private void stop()
    {
        Reapear.enabled=false;
    }
}
