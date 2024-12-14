using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject playerInventory;
    private bool isInventoryOpened;
    private void FixedUpdate()
    {
        if (isInventoryOpened)
        {
            playerInventory.SetActive(true);
        }
        else
        {
            playerInventory.SetActive(false);
        }
    }
    public void OpenInventory()
    {
        if (isInventoryOpened)
        {
            isInventoryOpened = false; 
        }
        else
        {
            isInventoryOpened = true;
        }
    }
}
