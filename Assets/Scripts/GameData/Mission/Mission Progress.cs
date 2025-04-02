using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionProgress : MonoBehaviour
{
    public static MissionProgress instance;
    [Header("--0 = major,1 = robert, 2 = caroline, 3 = black smith--")]
    [SerializeField] private List<GameObject> Npc_mission_button;
    public int Player_Mission_Progress = 0;
    private string NPCName;
    public List<MainMission> missions;
   
    
    private void Awake()
    {
        instance= this;
    }
    private void FixedUpdate()
    {
        //mission 00

        NPCName= missions[Player_Mission_Progress].npc_name.ToString();
        switch(NPCName)
        {
            //--0 = major,1 = robert, 2 = caroline, 3 = black smith--
            case "None":
                for (int i = 0;i< Npc_mission_button.Count; i++)
                {
                    Npc_mission_button[i].SetActive(false);
                }
                break;
            case "Robert":
                for (int i=0;i< Npc_mission_button.Count; i++)
                {
                    if (i== 1)
                    {
                        Npc_mission_button[i].SetActive(true);
                    }
                    else
                    {
                        Npc_mission_button[i].SetActive(false);
                    }
                }
                break;
            case "Caroline":
                for (int i = 0; i < Npc_mission_button.Count; i++)
                {
                    if (i == 2)
                    {
                        Npc_mission_button[i].SetActive(true);
                    }
                    else
                    {
                        Npc_mission_button[i].SetActive(false);
                    }
                }
                break;
            case "Major":
                for (int i = 0; i < Npc_mission_button.Count; i++)
                {
                    if (i == 0)
                    {
                        Npc_mission_button[i].SetActive(true);
                    }
                    else
                    {
                        Npc_mission_button[i].SetActive(false);
                    }
                }
                break;
            case "Black Smith":
                for (int i = 0; i < Npc_mission_button.Count; i++)
                {
                    if (i == 3)
                    {
                        Npc_mission_button[i].SetActive(true);
                    }
                    else
                    {
                        Npc_mission_button[i].SetActive(false);
                    }
                }
                break;
            
        }
    }
}

[System.Serializable]
public class MainMission
{
    public string name;//ten
    public string description;//mo ta
    public string chu_thich_developer;

    public NPC_Name npc_name;
    public enum NPC_Name
    {
        Robert,
        Major,
        BlackSmith,
        Caroline,
        None
    }
    [Header("--Da kich hoat chua--")]public bool is_active= false;
    [Header("--Lan dau nhan NV")] public bool first_time = true;
    [Header("--Trang thai nhiem vu--")]public bool is_completed = false;

    //item yeu cau
    [Header("Item Yeu cau")] public Item req;
    [Header("Ten Item Yeu cau")] public string req_item_name;
    [Header("--NV co yeu cau Item khong?--")] public bool item_required = false;
    // so luong yeu cau
    public int require1;

    // tien do nhiem vu
    public int progress1;

    //phan thuong
    public Item reward;
    [Header("--So luong phan thuong--")] public int quantity;
    public string rewardText;

    //loi thoai
    [Header("--Loi thoai voi NPC--")] public List<string> dialogue;//loi thoai voi npc
    [Header("--Avatar voi NPC--")] public List<Sprite> dialogueAvatar;//avtar khi noi chuyen voi npc
    [Header("--Cau truyen voi NPC--")]public string storyLine;//cau truyen
}
