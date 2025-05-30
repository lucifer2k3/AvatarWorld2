﻿using System.Collections;
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
    private void FixedUpdate()
    {
        UpdateInventory();
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
    // kiem tra item da co trong kho chua
    // kiem tra so luong item
    public bool CheckItem(string itemname,int quantity)
    {
        for (int i = 0; i < 24; i++)
        {
            if (this.item[i] != null)
            {
                if (itemname == this.item[i].itemName.ToString())
                {
                    if (this.item[i].amount >= quantity)
                    {
                        return true;
                    }
                    
                }
            }
        }
        return false;
    }
    public void AddItem(Item Item, int amount)
    {
        //check item nếu là vàng
        if (Item.name == "Gold")
        {
            PlayerStats.instance.playerGold += amount;
            ActiveReceive.instance.ShowInfo("Nhận được " + amount + " vàng");
            return;
        }
        
        //check Item trung' id
        for (int i = 0; i < 24; i++)
        {
            if (item[i])
            {
                if (item[i].itemName == Item.itemName)
                {
                    QuestCheck(Item, amount);
                    item[i].amount += amount;
                    ActiveReceive.instance.ShowInfo("Nhận được " + amount + " " + Item.itemName);
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
                ActiveReceive.instance.ShowInfo("Nhận được " + amount + " " + Item.itemName);
                QuestCheck(Item, amount);
                return;
            }
        //check invent neu full
            if (i == 23)
            {
                ActiveReceive.instance.ShowInfo("3Hòm đồ đã đầy");
                return;
            }
        }

    }
    // kiem tra dieu kien cho nhiem vu
    private void QuestCheck(Item Item,int amount)
    {
        /*Nhiem vu 01(Kiem tra go)*/
        if (MissionProgress.instance.Player_Mission_Progress == 1 && MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 1)
        {
            if (Item.itemName == "Gỗ sồi")
            {
                MissionProgress.instance.missions[1].progress1 += amount;
            }
        }
        if(MissionProgress.instance.Player_Mission_Progress == 2 && MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 1)
        {
            if (Item.itemName == "Quặng sắt")
            {
                MissionProgress.instance.missions[2].progress1 += amount;
            }
        }
        if(MissionProgress.instance.Player_Mission_Progress == 4 && MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 1)
        {
            if (Item.itemName == "Lúa mì")
            {
                MissionProgress.instance.missions[2].progress1 += amount;
            }
        }
        if(MissionProgress.instance.Player_Mission_Progress == 5 && MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 1)
        {
            if (Item.itemName == "Bột mì")
            {
                MissionProgress.instance.missions[2].progress1 += amount;
            }
        }
        if (MissionProgress.instance.Player_Mission_Progress == 10 && MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 1)
        {
            if (Item.itemName == "Gỗ sồi")
            {
                MissionProgress.instance.missions[10].progress1 += amount;
            }
        }
        if (MissionProgress.instance.Player_Mission_Progress == 11 && MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 1)
        {
            if (Item.itemName == "Đá")
            {
                MissionProgress.instance.missions[11].progress1 += amount;
            }
        }
    }
    public void RemoveItem()
    {
        if (StorageController.instance.choosingButton != -1)
        {
            if (this.item[StorageController.instance.choosingButton].amount >0)
            {
                this.item[StorageController.instance.choosingButton].amount = 0;
                StorageController.instance.choosingButton = -1;
                RobertStore.shopStorageBoxPos = -1;
                UpdateInventory();
                return;
            }
        }
    }
    public void QuestRemove(string item,int quantity)
    {
        if (CheckItem(item, quantity)){
            for (int i = 0; i < 24; i++)
            {
                if (this.item[i] != null)
                {
                    if (item == this.item[i].itemName.ToString())
                    {
                        this.item[i].amount -= quantity;
                        return;
                    }
                }
            }
        }
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
        print("khong tim thay item");
    }
    public void SellItem(int pos)
    {
        if (item[pos])
        {
            PlayerStats.instance.playerGold += item[pos].amount * item[pos].price;
            item[pos].amount = 0;
        }
        else print("có lỗi xảy ra");
    }
    public void BuyItem(Item item, int amount,float discount)
    {
        if (PlayerStats.instance.playerGold >= item.sellingPrice * amount)
            {
                PlayerStats.instance.playerGold -= discount* item.sellingPrice * amount;
                this.AddItem(item, amount);
                
            // quest 01
            if (item.name == "Cuốc")
            {
                if (MissionProgress.instance.missions[0].progress1< MissionProgress.instance.missions[0].require1)
                {
                    MissionProgress.instance.missions[0].progress1++;
                }
            }
            }



        else
            {
                // co loi xay ra
            } 
    }
}
