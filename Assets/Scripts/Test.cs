using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Item item;
    public Item item2;

    public void AddItemTest()
    {
        PlayerInvent.instance.AddItem(item,1);
        PlayerInvent.instance.AddItem(item2,1);
    }
}
