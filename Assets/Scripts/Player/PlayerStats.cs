using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;


    public bool tired = false;
    public PlayerInvent[] playerItems = new PlayerInvent[24];
    public int choosingItem = 0; 
    private void Awake(){
        instance = this;
    }
    private void Start()
    {
        InvokeRepeating("UpdateInventory", 1f, 0.5f);
    }
    private void UpdateInventory()
    {
        for (int i=0;i<24;i++) 
        {
            if (playerItems[i].amount==0) 
            {
                playerItems[i].item = null;
            }
        }
    }
    public void AddItem(Item item,int amount)
    {
        for (int i=0;i<24;i++)
        {
            if (playerItems[i].item)
            {
                if (playerItems[i].item.id == item.id)
                {
                    playerItems[i].amount += amount;
                    return;
                }
            }
        }
        for (int i=0;i< 24;i++)
        {
            if (playerItems[i].item == null)
            {
                playerItems[i].item = item;
                playerItems[i].amount = amount;
                return;
            }
            if (i == 23)
            {
                print(playerItems[i].item);
                return;
            }
        }
    }
    public void RemoveItem(Item item,int amount)
    {

    }
}
