using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item Name", menuName = "New Item")]
public class Item : ScriptableObject
{
    public enum itemTypes{
        Seed,
        Hoe,
        Axe,
        Product
    }
    //chung


    public int id=0;
    public itemTypes itemType;
    public Sprite itemImage;


    public string itemName;
    public string itemDes;

    [Header("--Gia ban thanh pham--")]
    public int price;// Gi� b�n th�nh ph?m
    [Header("--Gia ban hat giong--")]
    public int sellingPrice;// Gi� mua h?t gi?ng, nguy�n li?u
    public int amount = 0;

    public GameObject gameObjectWhilePlant;
}
