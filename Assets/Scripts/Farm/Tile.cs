using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Tile : MonoBehaviour
{
    private SpriteLibrary spriteLibrary;
    private SpriteRenderer renderer;
    [SerializeField]private SpriteRenderer interaction;
    private BoxCollider2D boxCol;

    public GameObject plant ;

    private bool isWatered = false;
    private bool canPlant = false;
    public bool isPlanted = false;

    private Item item;

    private void Awake()
    {
        this.spriteLibrary = GetComponent<SpriteLibrary>();
        this.renderer = GetComponent<SpriteRenderer>();
        boxCol = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        switch (isPlanted)
        {
            case true:
                boxCol.enabled = false;
                break;
            case false:
                boxCol.enabled = true;
                break;
        }
        switch (canPlant)
        {
            case false:
                {
                    if (isPlanted == false)
                    {
                        renderer.sprite = null;
                        break;
                    }
                    if (isPlanted)
                    {
                        break;
                    }
                    break;
                }
            case true:
                {
                    renderer.sprite = spriteLibrary.GetSprite("Dirt", "w1");
                    break;
                }
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
                    plant = Instantiate(PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].gameObjectWhilePlant, transform.position, transform.rotation);
                    plant.transform.parent = transform;
                    PlayerInvent.instance.UseItem(PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]], 1);
                }
            }
        }
    }
    void OnMouseExit(){
        interaction.sprite = null;
    }
}
