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
    public Item[] playerItems = new Item[23];

    private void Awake(){
        instance = this;
    }
    public void AddItem(Item item)
    {
        for (int i = 0; i < 24;i++)
        {
            if (item.id != playerItems[i].id)
            {
                //smth happen
            }
        }
    }
}
