using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Bloc : MonoBehaviour
{
    public Tilemap tilemap;
    //public Vector3Int posi;
    public GameObject Bomb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posi = new Vector3(-1f,1f,0f);
        Vector3Int position = new Vector3Int(Mathf.FloorToInt(posi.x), Mathf.FloorToInt(posi.y), Mathf.FloorToInt(posi.z));

        //if(Input.GetMouseButtonDown(0))
        //{
        //    Vector3 worldPus= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Vector3Int cellPos = tilemap.WorldToCell(worldPus);
        //    tilemap.SetTile(cellPos, null);
        //}

        tilemap.SetTile(position, null);
    }
}
