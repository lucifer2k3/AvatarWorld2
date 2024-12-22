using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Item item;
    public void AddItemTest(int amount)
    {
        PlayerInvent.instance.AddItem(item,3);
    }
}
