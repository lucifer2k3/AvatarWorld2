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

    private void Awake(){
        instance = this;
    }
    public void AddItem(Item item,int amount)
    {
        for (int i=0;i<24;i++)
        {
            if (playerItems[i].item.id == item.id)
            {
                playerItems[i].amount += amount;
            } 
        }
        for (int i=0;i< 24;i++)
        {
            if (playerItems[i] == null)
            {
                playerItems[i].item = item;
                playerItems[i].amount = amount;
            }
            if (i == 23)
            {
                print(playerItems[i].item);
            }
        }
    }
    public void RemoveItem(Item item,int amount)
    {

    }
}
