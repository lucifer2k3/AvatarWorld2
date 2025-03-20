using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    [SerializeField] private List<GameObject> all_Inventory_Menus;
    public static int InventoryMenuIndex=0;
    private void FixedUpdate()
    {
        for (int i = 0; i < all_Inventory_Menus.Count; i++)
        {
            if (i== InventoryMenuIndex)
            {
                all_Inventory_Menus[i].SetActive(true);
            }
            if (i!= InventoryMenuIndex)
            {
                all_Inventory_Menus[i].SetActive(false);
            }
        }
    }
}
