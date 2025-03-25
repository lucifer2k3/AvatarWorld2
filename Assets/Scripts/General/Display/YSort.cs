using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class YSort : MonoBehaviour
{
    [SerializeField]private Transform center;
    SpriteRenderer spriteRenderer ;
    void FixedUpdate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sortingOrder = -(int)center.position.y*100;
    }
}