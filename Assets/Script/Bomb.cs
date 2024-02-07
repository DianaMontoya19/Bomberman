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
    private bool deteccion;
    //public GameObject Fire;
    private int x, y;
    //public Vector3Int posi;
    public bool bom= true;
    public Tilemap tilemap;

    //public LayerMask layerSuelo;
    public Image imagen;
    GrillMOve move;
    Animator anim;

    private void Start()
    {
      anim = GetComponent<Animator>();
      move = GetComponent<GrillMOve>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //imagen.enabled = true;
            //Vector2 posi = move.CalcularDireccion(x, y);
            Vector3 pos =  Player.transform.position;
           
            //Vector3Int position2 = new Vector3Int(Mathf.FloorToInt(pos.x - 13), Mathf.FloorToInt(pos.y - 4), Mathf.FloorToInt(pos.z));
            //Vector3Int position3 = new Vector3Int(Mathf.FloorToInt(pos.x - 14), Mathf.FloorToInt(pos.y - 5), Mathf.FloorToInt(pos.z));
            //Vector3Int position4 = new Vector3Int(Mathf.FloorToInt(pos.x - 13), Mathf.FloorToInt(pos.y - 6), Mathf.FloorToInt(pos.z));
            GameObject NewObject = Instantiate(bomb, pos, Quaternion.identity);
            //anim.SetTrigger("Fire");

            
            //if(deteccion)
            //{
            //    Vector3Int position = new Vector3Int(Mathf.FloorToInt(tf.position.x), Mathf.FloorToInt(tf.position.y), Mathf.FloorToInt(tf.position.z));
            //    tilemap.SetTile(position , null);
            //    Debug.Log("entro");
            //}
            

    
           




            bom = false; 
                    
        }
       
        
    }
}
