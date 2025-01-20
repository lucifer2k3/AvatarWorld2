
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public Item item; 
    private RobertStore rb;
    [SerializeField] private Image shopItemImage;
    [SerializeField] private TextMeshProUGUI itemName;
    void Start()
    {
        rb = GameObject.Find("Robert Shop UI").GetComponent<RobertStore>();
        shopItemImage.sprite = item.itemImage;
        itemName.text = item.name;
    }
    public void UpdateStore()
    {
        rb.choosingItem= item;
    }
}
