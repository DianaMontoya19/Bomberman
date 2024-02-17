using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Move : MonoBehaviour
{
    public GameObject post;
    // Permite que el gameobject que representa el fuego de la explosion, me siga todo el tiempo la bomba.
    private void Update()
    {
       
        transform.position = post.transform.position+ new Vector3(0f, 0f,0f);
    }

}
