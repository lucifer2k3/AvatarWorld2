using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Tile : MonoBehaviour
{
    private SpriteLibrary spriteLibrary;
    private SpriteRenderer renderer;
    [SerializeField]private SpriteRenderer interaction;


    public bool isWatered = false;
    public bool canPlant = false;
    public int state = 0;

    private void Awake()
    {
        this.spriteLibrary = GetComponent<SpriteLibrary>();
        this.renderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (state == 0)
        {

        }
    }
    void OnMouseEnter(){
        interaction.sprite = spriteLibrary.GetSprite("Dirt", "r1"); 
    }
    void OnMouseExit(){
        interaction.sprite = null;
    }
}
