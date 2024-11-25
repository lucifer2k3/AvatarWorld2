using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class YSortTilemap : MonoBehaviour
{
    void Start()
    {
        var tilemapRenderer = GetComponent<TilemapRenderer>();
        tilemapRenderer.sortingOrder = transform.GetSortingOrder();
    }

    
}
