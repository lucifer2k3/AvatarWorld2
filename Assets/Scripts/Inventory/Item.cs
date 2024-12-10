using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item Name", menuName = "New Item")]
public class Item : ScriptableObject
{
    public enum itemTypes{
        Seed,
        Weapon

    }

    public itemTypes itemType;
    public Sprite itemImage;
    public string itemName;
    public int amount=0;
    public int maxAmount;
    public float[] growTime = new float[7];
    public Sprite[] itemGrowPhase = new Sprite[7];
}
