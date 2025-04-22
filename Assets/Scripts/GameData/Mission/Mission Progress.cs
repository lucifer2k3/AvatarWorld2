using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionProgress : MonoBehaviour
{
    private bool FirstTime = true;

    public static MissionProgress instance;
    [Header("--0 = major,1 = robert, 2 = caroline, 3 = black smith--")]
    [SerializeField] private List<NPC_Mission_button> Npc_mission_button;


    public int Player_Mission_Progress = 0;
    public List<MainMission> missions;

    private void RewardCheck()
    {
        if (missions[Player_Mission_Progress].has_reward == true)
        {
            PlayerInvent.instance.AddItem(missions[Player_Mission_Progress].reward, missions[Player_Mission_Progress].quantity);
        }
    }
    public void TakeQuest()
    {
        missions[Player_Mission_Progress].quest_state = 1;
    }
    public void CompleteQuest()
    {
        //hoan thanh nv
        switch (Player_Mission_Progress)
        {
            case 0:
                Player_Mission_Progress++;
                break;
            case 1://nv 2
                if (PlayerInvent.instance.CheckItem("Gỗ sồi", 6) == true)
                {
                    PlayerInvent.instance.QuestRemove("Gỗ sồi", 6);
                    StoreHouse.House_lv = 2;
                    RewardCheck();
                    Player_Mission_Progress++;
                }
                else
                {
                    MesAndNoti.instance.SetNotification("Bạn không có đủ gỗ");
                }
                    break;
            case 2://nv 3
                if (PlayerInvent.instance.CheckItem("Quặng sắt", 3) == true)
                {
                    PlayerInvent.instance.QuestRemove("Quặng sắt", 3);
                    
                    RewardCheck();
                    Player_Mission_Progress++;
                }
                else
                {
                    MesAndNoti.instance.SetNotification("Bạn không có đủ sắt");
                }
                break;
            case 3://nv 4
                RewardCheck();
                Player_Mission_Progress++;
                
                break;
            case 4://nv 5
                break;
            case 5://nv 6
                break;
            case 6://nv 7
                if (PlayerInvent.instance.CheckItem("Bột mì", 15) == true)
                {
                    PlayerInvent.instance.QuestRemove("Bột mì", 15);
                    RewardCheck();Player_Mission_Progress++;
                }
                else
                {
                    MesAndNoti.instance.SetNotification("Bạn không đủ số bột mì yêu cầu");
                }
                break;
            case 7://nv 8
                Player_Mission_Progress++;
                break;
            case 8://nv 9
                Player_Mission_Progress++;
                break;
            case 9://nv 10
                if (PlayerInvent.instance.CheckItem("Gỗ sồi", 20) == true)
                {
                    PlayerInvent.instance.QuestRemove("Gỗ sồi", 20);
                    RewardCheck();
                    Player_Mission_Progress++;
                    
                }
                break;
            case 10://nv 11
                break;
            case 11:
                if (PlayerInvent.instance.CheckItem("Gỗ sồi", 20) == true && PlayerInvent.instance.CheckItem("Đá",15))
                {
                    PlayerInvent.instance.QuestRemove("Gỗ sồi", 20);
                    PlayerInvent.instance.QuestRemove("Đá", 15);
                    FarmHouse.instance.HouseLevel = 2;
                    RewardCheck();
                    Player_Mission_Progress++;
                    
                }
                else
                {
                    MesAndNoti.instance.SetNotification("Bạn không có đủ số nguyên liệu yêu cầu");
                }
                break;
        }
        //nhan thuong
        
    }
    private void Awake()
    {
        instance= this;
    }
    private void Start()
    {
        if (Player_Mission_Progress == 0)
        {
            if (FirstTime)
            {
                MesAndNoti.instance.SetMessage("Cháu yêu quý,\r\n\r\nÔng biết cháu luôn có một trái tim yêu mến đồng quê. Trang trại này là tâm huyết cả đời ông. Nay ông đã già, không còn đủ sức chăm sóc.\r\n\r\nÔng tin cháu sẽ là người kế thừa xứng đáng, biến nơi này thành một mái ấm và một trang trại trù phú. Hãy nhớ những kỷ niệm đẹp của chúng ta ở đây nhé.\r\n\r\nÔng luôn tin ở cháu.", "Ông nội");
                FirstTime = false;
            }
            //else
            //{
            //    Player_Mission_Progress = PlayerPrefs.GetInt("Player_Mission_Progress");
            //}
        }
    }
    private void FixedUpdate()
    {
        
        switch (missions[Player_Mission_Progress].quest_state)
        {
            case 0:
                for (int i=0;i<Npc_mission_button.Count; i++)
                {
                    if (Npc_mission_button[i].NPC_name == missions[Player_Mission_Progress].npc_name.ToString())
                    {
                        Npc_mission_button[i].button.SetActive(true);
                        Npc_mission_button[i].Mark.gameObject.SetActive(true);
                    }
                    else
                    {
                        Npc_mission_button[i].button.SetActive(false);
                        Npc_mission_button[i].Mark.gameObject.SetActive(false);
                    }
                }
                break;
            case 1:
                for (int i = 0; i < Npc_mission_button.Count; i++)
                {
                    Npc_mission_button[i].button.SetActive(false);
                    Npc_mission_button[i].Mark.gameObject.SetActive(false);
                }
                if (missions[Player_Mission_Progress].progress1 >= missions[Player_Mission_Progress].require1)
                {
                    missions[Player_Mission_Progress].progress1 = missions[Player_Mission_Progress].require1;
                    if (missions[Player_Mission_Progress].has_ending_dialogue)
                    {
                        missions[Player_Mission_Progress].quest_state = 2; 
                    }
                    else
                    {
                        missions[Player_Mission_Progress].quest_state = 3;
                    }
                }
                break;
            case 2:
                if (missions[Player_Mission_Progress].progress1 > missions[Player_Mission_Progress].require1)
                {
                    missions[Player_Mission_Progress].progress1 = missions[Player_Mission_Progress].require1;
                }
                for (int i = 0; i < Npc_mission_button.Count; i++)
                {
                    
                    if (Npc_mission_button[i].NPC_name == missions[Player_Mission_Progress].npc_name.ToString())
                    {
                        Npc_mission_button[i].button.SetActive(true);
                        Npc_mission_button[i].Mark.gameObject.SetActive(true);
                    }
                    else
                    {
                        Npc_mission_button[i].button.SetActive(false);
                        Npc_mission_button[i].Mark.gameObject.SetActive(false);
                    }
                }
                break;
            case 3:
                //sang luon nhiem vu thiep theo
                Player_Mission_Progress++;

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

    //quest state
    [Header("--0:Chua nhan NV" +
        "      1:Dang lam NV" +
        "      2:Du? DK hoan thanh NV--")]
    public int quest_state = 0;

    //item yeu cau
    [Header("--NV co yeu cau Item khong?--")] public bool item_required = false;
    [Header("Item Yeu cau")] public Item req;
    [Header("Ten Item Yeu cau")] public string req_item_name;
    
    // so luong yeu cau
    public int require1;

    // tien do nhiem vu
    public int progress1;

    //phan thuong
    public bool has_reward = false;
    [Header("Phan thuong")]public Item reward;
    [Header("--So luong phan thuong--")] public int quantity;
    public string rewardText;

    //loi thoai
    [Header("--Loi thoai nhan vat khi nhan nv--")]
    public List<string> earnquest_dialogue;
    public List<Sprite> earnquest_sprite;
    [Header("NV co ending dialogue khong ?")]
    public bool has_ending_dialogue = false;

    [Header("--Loi thoai khi hoan thanh nv--")]
    public List<string> completequest_dialogue;
    public List<Sprite> completequest_sprite;
    [Header("--Cau truyen voi NPC--")]public string storyLine;//cau truyen
}
[System.Serializable]
public struct NPC_Mission_button
{
    public string NPC_name;
    public GameObject button;
    public SpriteRenderer Mark;
}