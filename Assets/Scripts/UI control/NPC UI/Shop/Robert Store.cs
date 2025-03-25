using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RobertStore : MonoBehaviour
{

    public GameObject shopEnter;
    public GameObject shopBuyUI;
    public Item choosingItem;

    //stats
    [SerializeField]private TextMeshProUGUI moneyRemain;

    //shop UI
    [SerializeField]private GameObject shop;
    [SerializeField]private GameObject storage;

    [SerializeField]private TextMeshProUGUI itemName;
    [SerializeField]private TextMeshProUGUI itemDes;
    [SerializeField]private TextMeshProUGUI itemCost;

    //storage UI
    public static int shopStorageBoxPos = -1;
    [SerializeField]private TextMeshProUGUI shopStorageItemName;
    [SerializeField]private TextMeshProUGUI shopStorageItemDes;
    void Start()
    {
    }

    private void FixedUpdate()
    {
        moneyRemain.text = PlayerStats.instance.playerGold.ToString();
       if (choosingItem != null)
        {
            itemName.text = choosingItem.itemName.ToString();
            itemDes.text = choosingItem.itemDes.ToString();
            itemCost.text = "Giá: " +( Question.instance.discount* choosingItem.sellingPrice);
        }
       else
        {
            itemName.text = "";
            itemDes.text = "";
            itemCost.text = "";
        }
       if (shopStorageBoxPos != -1)
        {
            shopStorageItemName.text = PlayerInvent.instance.item[shopStorageBoxPos].itemName;
            shopStorageItemDes.text = PlayerInvent.instance.item[shopStorageBoxPos].itemDes;
        }
        else
        {
            shopStorageItemName.text = "";
            shopStorageItemDes.text = "";
        }
    }
    public void Leave()
    {
        shopEnter.SetActive(false);
    }
    public void LeaveShop()
    {
        shopStorageBoxPos = -1;
        shopBuyUI.SetActive(false);
    }
    public void EnterShop()
    {
        shop.SetActive(true);
        storage.SetActive(false);
        shopBuyUI.SetActive(true);
        shopEnter.SetActive(false);
    }
    public void BuyItem()
    {
        if (choosingItem != null)
        {
            PlayerInvent.instance.BuyItem(choosingItem, 1,Question.instance.discount);
            Question.instance.discount = 1;
        }
    }
    public void OpenShop()//mo shop
    {
        storage.SetActive(false);
        shop.SetActive(true);
    }
    public void OpenStorage()//mo kho do 
    {
        storage.SetActive(true);
        shop.SetActive(false);
    }
    public void SellItem()
    {
        if (shopStorageBoxPos != -1)
        {
            PlayerInvent.instance.SellItem(shopStorageBoxPos);
            shopStorageBoxPos= -1;
        }
        else
        {
            print("err");
        }
    }
}
