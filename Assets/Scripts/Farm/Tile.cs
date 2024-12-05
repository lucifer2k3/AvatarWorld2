using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class Tile : MonoBehaviour
{
    private SpriteRenderer dirtBlock;
    [SerializeField]private Sprite red;
    [SerializeField]private Sprite green;
    void Start()
    {
        dirtBlock = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnMouseEnter(){
        dirtBlock.sprite = green;
    }
    void OnMouseExit(){
        dirtBlock.sprite = null;
    }
}
