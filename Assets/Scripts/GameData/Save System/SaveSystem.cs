using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    // Singleton instance
    public static SaveSystem Instance { get; private set; }

    public void SaveAll()
    {
        PlayerSave();
        QuestProgressSave();
        InventorySave();
        PlantSave();
        HouseSave();
    }
    public void LoadAll()
    {

    }
    private void PlayerSave()
    {
        //pos
        //energy
    }
    private void QuestProgressSave()
    {
        //quest
        //quest progress
    }
    private void InventorySave()
    {
        //inventory
        //item
        //item progress
    }
    private void PlantSave()
    {
        //plant
        //plant progress
    }
    private void HouseSave()
    {
        //house
        //house progress
    }
}
