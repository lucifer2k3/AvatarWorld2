using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject playerInventory;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenInventory();
        }
    }
    public void CloseInventory()
    {
        if (playerInventory.activeInHierarchy)
        {
            playerInventory.SetActive(false);
        }
    }
    public void OpenInventory()
    {
        if (!playerInventory.activeInHierarchy)
        {
            playerInventory.SetActive(true);
        }
        else
        {
            playerInventory.SetActive(false);
        }
    }
}
