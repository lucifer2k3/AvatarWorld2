﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Tile : MonoBehaviour
{
    private Transform playerTransform;

    private SpriteLibrary spriteLibrary;
    private SpriteRenderer render;
    [SerializeField]private SpriteRenderer interaction;
    private BoxCollider2D boxCol;

    public GameObject plant ;

    private bool isWatered = false;
    private bool canPlant = false;
    public bool isPlanted = false;

    private Item item;

    private void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        if (playerTransform == null)
        {
            Debug.LogError("Player không được tìm thấy trong scene!");
        }
        this.spriteLibrary = GetComponent<SpriteLibrary>();
        this.render = GetComponent<SpriteRenderer>();
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
                        render.sprite = null;
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
                    render.sprite = spriteLibrary.GetSprite("Dirt", "w1");
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
                    //check nang luong cua nhan vat
                    if (PlayerStats.instance.player_now_energy>0)
                    {
                        if (playerTransform.position.x > transform.position.x)
                        {
                            PlayerController.instance.hoetrigger(true);
                        }
                        else
                        {
                            PlayerController.instance.hoetrigger(false);
                        }
                        PlayerStats.instance.player_now_energy-=1;
                        canPlant = true; 
                        
                    }
                    else
                    {
                        MesAndNoti.instance.SetNotification("Bạn đã mệt, cần nghỉ ngơi");
                        //thong bao ban da met, can nghi ngoi
                    }
                } 
            }
        }
        if (canPlant == true)
        {
            if (ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem] != -1)
            {
                if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].itemType.ToString() == "Seed")
                {
                    if (PlayerStats.instance.player_now_energy>0)
                    {
                        PlayerStats.instance.player_now_energy-=1;
                        canPlant = false;
                        isPlanted = true;
                        item = PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]];
                        plant = Instantiate(PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]].gameObjectWhilePlant, transform.position, transform.rotation);
                        plant.transform.parent = transform;
                        PlayerInvent.instance.UseItem(PlayerInvent.instance.item[ItemBinding.instance.posInInvent[ItemBinding.instance.usingItem]], 1);
                    }
                    else
                    {
                        MesAndNoti.instance.SetNotification("Bạn đã mệt, cần nghỉ ngơi");
                        //thong bao ban da met, can nghi ngoi
                    }
                }
            }
        }
    }
    void OnMouseExit(){
        interaction.sprite = null;
    }
}
