using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    // Singleton instance
    public static SaveSystem Instance { get; private set; }

    public static SaveSystem instance;
    private string saveFilePath;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            saveFilePath = Application.persistentDataPath + "/gameData.json";
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SaveGameData()
    {
        GameData data = new GameData();
        data.Virtual_Camera = AllCameraControl.playerpos; // Set the virtual camera ID or any other relevant data
        Transform player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 

        data.PlayerPositionX =player.position.x ;
        data.PlayerPositionY = player.position.y;

        data.PlayerNowEnergy = PlayerStats.instance.player_now_energy;
        data.PlayerGold = PlayerStats.instance.playerGold;

        data.InventoryItems = PlayerInvent.instance.item;

        data.Quest_Number = MissionProgress.instance.Player_Mission_Progress;
        data.Quest_Progress = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].progress1;

        data.House_level = FarmHouse.instance.HouseLevel;
        data.StoreHouse_level = StoreHouse.House_lv;

        string jsonData = JsonUtility.ToJson(data);

        try
        {
            File.WriteAllText(saveFilePath, jsonData);
            Debug.Log("Đã lưu dữ liệu vào: " + saveFilePath);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Lỗi khi lưu dữ liệu: " + e.Message);
        }
    }



    private void PlantSave()
    {
        //plant
        //plant progress
    }
    
}

[System.Serializable]
public class GameData
{
    public int Virtual_Camera;

    public float PlayerPositionX;
    public float PlayerPositionY;

    public float PlayerNowEnergy;
    public float PlayerGold;

    public int Quest_Number;
    public int Quest_Progress;

    public Item[] InventoryItems= new Item[24];
    //plant


    //nha va nha kho
    public int House_level;
    public int StoreHouse_level;
}

