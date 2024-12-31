using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Tile : MonoBehaviour
{
    private SpriteLibrary spriteLibrary;
    private SpriteRenderer renderer;
    [SerializeField]private SpriteRenderer interaction;


    private bool isWatered = false;
    private bool canPlant = false;
    private bool isPlanted = false;

    private Item item;

    private void Awake()
    {
        this.spriteLibrary = GetComponent<SpriteLibrary>();
        this.renderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (canPlant == false && isPlanted == false)
        {
            renderer.sprite = null;
        }
        if (canPlant)
        {
            renderer.sprite = spriteLibrary.GetSprite("Dirt", "w1");
        }
        if (isPlanted)
        {

        }
    }
    void OnMouseEnter(){
        if (canPlant == false)
        {
            if (ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem] != -1)
            {
                if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].itemType.ToString() == "Hoe")
                {
                    interaction.sprite = spriteLibrary.GetSprite("Dirt", "r1");
                }
            }
        }
        if (canPlant == true)
        {
            if (ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem] != -1)
            {
                if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].itemType.ToString() == "Hoe")
                {
                    interaction.sprite = spriteLibrary.GetSprite("Dirt", "r2");
                }
                if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].itemType.ToString() == "Seed")
                {
                    interaction.sprite = spriteLibrary.GetSprite("Dirt", "r1");
                } 
            }
        } 
    }
    private void OnMouseDown()
    {
        if (canPlant == false)
        {
            if (ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem] != -1)
            {
                if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].itemType.ToString() == "Hoe")
                {
                    canPlant = true;
                } 
            }
        }
        if (canPlant == true)
        {
            if (ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem] != -1)
            {
                if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].itemType.ToString() == "Seed")
                {
                    canPlant = false;
                    isPlanted = true;
                    item = PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]];
                    PlayerInvent.instance.UseItem(PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]], 1);
                }
            }
        }
    }
    void OnMouseExit(){
        interaction.sprite = null;
    }
}
