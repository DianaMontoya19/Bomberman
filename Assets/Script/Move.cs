using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Move : MonoBehaviour
{
    public Transform post;
    private void Update()
    {
        post = GetComponent<Transform>();
        post.position = transform.position;
    }

}
