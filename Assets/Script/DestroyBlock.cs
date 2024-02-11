using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestroyBlock : MonoBehaviour
{
    public Tilemap tilemap;
    public LayerMask layerMask;
    public GameObject Bomb;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Vector2 Origin = Bomb.transform.position;
        Vector2 DirRight = Vector2.right;
        Vector2 DirLeft = Vector2.left;
        Vector2 DirUp = Vector2.up;
        Vector2 DirDown = Vector2.down;


        // Realizar el Raycast
        RaycastHit2D hitInfo = Physics2D.Raycast(Origin, DirRight, 1f, layerMask);
        RaycastHit2D hitInfo2 = Physics2D.Raycast(Origin, DirLeft, 1f, layerMask);
        RaycastHit2D hitInfo3 = Physics2D.Raycast(Origin, DirUp, 1f, layerMask);
        RaycastHit2D hitInfo4 = Physics2D.Raycast(Origin, DirDown, 1f, layerMask);

        Vector3 posi = hitInfo.point;
        Vector3 posi2 = hitInfo2.point;
        Vector3 posi3 = hitInfo3.point;
        Vector3 posi4 = hitInfo4.point;


        if (hitInfo)
        {

            Vector3Int position2 = new Vector3Int(Mathf.FloorToInt(posi.x + 1), Mathf.FloorToInt(posi.y), Mathf.FloorToInt(posi.z));


            tilemap.SetTile(position2, null);

        }
        if (hitInfo2)
        {

            Vector3Int position2 = new Vector3Int(Mathf.FloorToInt(posi2.x - 1), Mathf.FloorToInt(posi2.y), Mathf.FloorToInt(posi2.z));
            tilemap.SetTile(position2, null);

        }
        if (hitInfo3)
        {

            Vector3Int position2 = new Vector3Int(Mathf.FloorToInt(posi3.x), Mathf.FloorToInt(posi3.y + 1), Mathf.FloorToInt(posi3.z));
            tilemap.SetTile(position2, null);

        }
        if (hitInfo4)
        {

            Vector3Int position2 = new Vector3Int(Mathf.FloorToInt(posi4.x), Mathf.FloorToInt(posi4.y - 1), Mathf.FloorToInt(posi4.z));
            tilemap.SetTile(position2, null);

        }
    }

}
