using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    //public int cantidad = 1;
    private Vector2[] aleatorio;
    //private Vector3 aletory;
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {

            aleatorio[i] = PosicionNueva();
            

        }
       foreach (Vector2 posi in aleatorio)
       {
          Instantiate(enemy,posi,Quaternion.identity);
       }

    }

    Vector2 PosicionNueva()
    {
        float positionX = Random.Range(-10, 10);
        float positionY = Random.Range(-10, 10);

       return new Vector2(positionX, positionY);
    }

}
