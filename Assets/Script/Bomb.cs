using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class Bomb : MonoBehaviour
{
    public GameObject Player;
    public GameObject bomb;
    public GameObject Fire;
    private int x, y;
    //public Vector3Int posi;
    public bool bom= true;
    public Tilemap tilemap;
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
            //Vector2 posi = move.CalcularDireccion(x, y);
            Vector3 pos =  Player.transform.position;
            Vector3Int position = new Vector3Int(Mathf.FloorToInt(pos.x), Mathf.FloorToInt(pos.y), Mathf.FloorToInt(pos.z));


            GameObject NewObject = Instantiate(bomb,pos, Quaternion.identity);

            tilemap.SetTile(position, null);




            bom = false; 
                    
        }
       
        
    }
}
