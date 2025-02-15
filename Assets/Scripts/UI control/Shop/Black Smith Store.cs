using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlackSmithStore : MonoBehaviour
{

    public GameObject shopEnter;
    public GameObject shopBuyUI;
    public Item choosingItem;

    //stats
    [SerializeField] private TextMeshProUGUI moneyRemain;

    //shop UI
    [SerializeField] private GameObject shop;

    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemDes;
    [SerializeField] private TextMeshProUGUI itemCost;

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
            itemCost.text = "Giá: " + choosingItem.sellingPrice;
        }
        else
        {
            itemName.text = "";
            itemDes.text = "";
            itemCost.text = "";
        }
    }
    public void Leave()
    {
        shopEnter.SetActive(false);
    }
    public void LeaveShop()
    { 
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
            PlayerInvent.instance.BuyItem(choosingItem, 1);
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
}

