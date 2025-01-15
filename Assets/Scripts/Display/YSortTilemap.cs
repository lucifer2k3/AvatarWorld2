using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class YSortTilemap : MonoBehaviour
{
    public TilemapRenderer tile;
    public Transform trans;
    void Start()
    {
        tile = GetComponent<TilemapRenderer>();
        trans = transform.Find("Test").GetComponent<Transform>();
        tile.sortingOrder = -(int)trans.position.y * 100;
    }

    
}
