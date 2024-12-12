using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName ="Slot", menuName ="Player Inventory Slot")]
[System.Serializable]
public class PlayerInvent : ScriptableObject
{
    public Item item;
    public int amount;
}
