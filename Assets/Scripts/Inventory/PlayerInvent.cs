using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvent : MonoBehaviour
{
    public static PlayerInvent instance;
    public Item[] item= new Item[24];
    public bool inventoryFull = false;
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
            // check neu amount == 0 thi xoa item
                if (item[i].amount == 0)
                {
                    item[i] = null;
                }
            }
            
        }
    }
    public void AddItem(Item Item, int amount)
    {
        //check Item trung' id
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
    public void UseItem(Item Item, int amount)
    {
        //check Item trung' id
        for (int i = 0; i < 24; i++)
        {
            if (item[i])
            {
                if (item[i].id == Item.id)
                {
                    item[i].amount -= amount;
                    return;
                }
            }
        }
    }
    public void SellItem(int pos, int amount)
    {
        if (item[pos] != null)
        {
            PlayerStats.instance.playerGold += item[pos].amount * item[pos].price;
            item[pos].amount = 0;
        }
        else print("có lỗi xảy ra");
    }
    public void BuyItem(Item item, int amount)
    {
        PlayerStats.instance.playerGold -= item.sellingPrice * amount;
        this.AddItem(item, amount);
    }
}
