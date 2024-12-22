using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvent : MonoBehaviour
{
    public static PlayerInvent instance;
    public Item[] item= new Item[24];
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        InvokeRepeating("UpdateInventory", 1f, 0.3f);
    }
    void UpdateInventory()
    {
        for (int i = 0; i < item.Length; i++)
        {
            if (item[i] != null) 
            {
                if (item[i].amount == 0)
                {
                    item[i] = null;
                }
            }
            
        }
    }
    public void AddItem(Item Item, int amount)
    {
        //check Item trung id
        for (int i = 0; i < 24; i++)
        {
            if (item[i])
            {
                if (item[i].id == Item.id)
                {
                    item[i].amount += amount;
                    return;
                }
            }
        }
        //check Item null
        for (int i = 0; i < 24; i++)
        {
            if (item[i] == null)
            {
                item[i] = Item;
                item[i].amount = amount;
                return;
            }
        //check invent neu full
            if (i == 23)
            {
                print(item[i].name);
                return;
            }
        }
    }
    public void RemoveItem(Item item, int amount)
    {

    }
}
