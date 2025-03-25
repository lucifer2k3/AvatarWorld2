using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftItem : MonoBehaviour
{
    [SerializeField] private int this_Item_Id;
    public void ChangeChoosingItemValue() 
    {
        CraftMenuControl.Instance.choosing_Item = this_Item_Id;
    }
}
