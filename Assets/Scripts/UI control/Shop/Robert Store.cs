using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobertStore : MonoBehaviour
{

    public GameObject shopEnter;
    public GameObject shopBuyUI;
    public Item choosingItem;
    void Start()
    {
    }

    void Update()
    {
        
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
        shopBuyUI.SetActive(true);
        shopEnter.SetActive(false);
    }
    public void BuyItem()
    {
        if (choosingItem != null)
        {
            PlayerInvent.instance.BuyItem(choosingItem, 1);
            choosingItem = null;
        }
    }
}
