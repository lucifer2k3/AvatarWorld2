using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionProgress : MonoBehaviour
{
    public static MissionProgress instance;
    [Header("--0 = major,1 = robert, 2 = caroline, 3 = black smith--")]
    [SerializeField] private List<NPC_Mission_button> Npc_mission_button;
    public int Player_Mission_Progress = 0;
    public List<MainMission> missions;
    
    
    public void TakeQuest()
    {
        missions[Player_Mission_Progress].quest_state = 1;
    }
    
    private void Awake()
    {
        instance= this;
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
                        return;
                    }
                    else
                    {
                        Npc_mission_button[i].button.SetActive(false);
                        return;
                    }
                }
                break;
            case 1:
                for (int i = 0; i < Npc_mission_button.Count; i++)
                {
                    Npc_mission_button[i].button.SetActive(false);
                }
                if (missions[Player_Mission_Progress].require1 == missions[Player_Mission_Progress].progress1)
                {
                    missions[Player_Mission_Progress].quest_state = 2;
                }
                break;
            case 2:
                for (int i = 0; i < Npc_mission_button.Count; i++)
                {
                    if (Npc_mission_button[i].NPC_name == missions[Player_Mission_Progress].npc_name.ToString())
                    {
                        Npc_mission_button[i].button.SetActive(true);
                        return;
                    }
                    else
                    {
                        Npc_mission_button[i].button.SetActive(false);
                        return;
                    }
                }
                break;
        }
    }
}
[System.Serializable]
public struct NPC_Talk
{
    public string dialogue;
    public Sprite avatar;
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
    public Item reward;
    [Header("--So luong phan thuong--")] public int quantity;
    public string rewardText;

    //loi thoai
    [Header("--Loi thoai nhan vat--")]
    public List<string> npc_dialogue;
    public List<Sprite> npc_sprite;
    [Header("--Cau truyen voi NPC--")]public string storyLine;//cau truyen
}
[System.Serializable]
public struct NPC_Mission_button
{
    public string NPC_name;
    public GameObject button;
}