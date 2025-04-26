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
    public void LoadGame()
    {
        GameData data = LoadGameData();
        //virtual camera
        AllCameraControl.playerpos = data.Virtual_Camera;
        //player pos
        Transform playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerTransform.position = new Vector2(data.PlayerPositionX, data.PlayerPositionY);

        //player stats
        PlayerStats.instance.player_now_energy = data.PlayerNowEnergy;
        PlayerStats.instance.playerGold = data.PlayerGold;
        //quest 
        MissionProgress.instance.Player_Mission_Progress = data.Quest_Number;
        MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].progress1 = data.Quest_Progress;
        //inventory
        for (int i = 0; i < 24; i++)
        {
            if (data.InventoryItems[i] != null)
            {
                PlayerInvent.instance.AddItem(data.InventoryItems[i], data.InventoryItems[i].amount);
            }
        }
        //plant


        //houseLV
        FarmHouse.instance.HouseLevel = data.House_level;
        StoreHouse.House_lv = data.StoreHouse_level;


    }
    public GameData LoadGameData()
    {
        if (File.Exists(saveFilePath))
        {
            try
            {
                string jsonData = File.ReadAllText(saveFilePath);
                GameData loadedData = JsonUtility.FromJson<GameData>(jsonData);
                Debug.Log("Đã tải dữ liệu từ: " + saveFilePath);
                return loadedData;
            }
            catch (System.Exception e)
            {
                Debug.LogError("Lỗi khi tải dữ liệu: " + e.Message);
                return null;
            }
        }
        else
        {
            Debug.LogWarning("Không tìm thấy tệp lưu dữ liệu tại: " + saveFilePath);
            return null;
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

        for (int i=0;i<24;i++)
        {
            if (PlayerInvent.instance.item[i] != null)
            { data.InventoryItems[i] = PlayerInvent.instance.item[i];
                data.ItemQuantity[i] = PlayerInvent.instance.item[i].amount;  }
        }
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
    //virtual camera
    public int Virtual_Camera;
    //player Pos
    public float PlayerPositionX;
    public float PlayerPositionY;
    //playerstats
    public float PlayerNowEnergy;
    public float PlayerGold;
    //quést
    public int Quest_Number;
    public int Quest_Progress;
    // inventory
    public Item[] InventoryItems= new Item[24];
    public int[] ItemQuantity = new int[24];
    //plant


    //nha va nha kho
    public int House_level;
    public int StoreHouse_level;
}

