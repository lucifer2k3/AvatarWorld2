using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item Name", menuName = "New Item")]
public class Item : ScriptableObject
{
    public enum itemTypes{
        Seed,
        Weapon,
        Product
        
    }
    public int id;
    public itemTypes itemType;
    public Sprite itemImage;
    public string itemName;
    public string itemDes;
    public int price;

}
