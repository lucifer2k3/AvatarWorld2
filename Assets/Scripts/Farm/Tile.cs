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

    private void Awake()
    {
        this.spriteLibrary = GetComponent<SpriteLibrary>();
        this.renderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (canPlant == false)
        {
            renderer.sprite = null;
        }
        if (canPlant)
        {
            renderer.sprite = spriteLibrary.GetSprite("Dirt", "w1");
        }
    }
    void OnMouseEnter(){
        if (canPlant == false)
        {
            if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].id == 3)
            {
                if (ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]!=-1)
                {
                    interaction.sprite = spriteLibrary.GetSprite("Dirt", "r1"); 
                }
            }
        }
        if (canPlant==true
            && PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].id==3 )
        {
            interaction.sprite = spriteLibrary.GetSprite("Dirt", "r2");
        } 
    }
    private void OnMouseDown()
    {
        if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].id == 3
            && canPlant == false)
        {
            canPlant = true;
        }
    }
    void OnMouseExit(){
        interaction.sprite = null;
    }
}
