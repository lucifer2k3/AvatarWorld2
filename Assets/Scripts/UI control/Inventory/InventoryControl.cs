using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    [SerializeField] private GameObject player_Storage;
    //[SerializeField] private GameObject craft_menu;
    //[SerializeField] private GameObject relationship_menu;
    [SerializeField] private GameObject mission_menu;
    public void OpenPlayerStorage()
    {
        player_Storage.SetActive(true);
        mission_menu.SetActive(false);
        //relationship_menu.SetActive(false);
        //craft_menu.SetActive(false);
    }
    public void OpenCraftMenu()
    {
        player_Storage.SetActive(false);
        mission_menu.SetActive(false);
        //relationship_menu.SetActive(false);
        //craft_menu.SetActive(true);
    }
    public void OpenMissionMenu()
    {
        player_Storage.SetActive(false);
        mission_menu.SetActive(true);
        //relationship_menu.SetActive(false);
        //craft_menu.SetActive(false);
    }
}
