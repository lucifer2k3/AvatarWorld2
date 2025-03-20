using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInventoryMenuIndex : MonoBehaviour
{
    [SerializeField] private int index;
    public void ChangeIndex()
    {
        InventoryControl.InventoryMenuIndex = index;
    }
}
