using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionProgress : MonoBehaviour
{
    public static MissionProgress instance;
    public int Player_Mission_Progress = 0;
    public List<MainMission> missions;

    private void Awake()
    {
        instance= this;
    }
}
[System.Serializable]
public class MainMission
{
    public string name;//ten
    public string description;//mo ta

    [Header("--Da kich hoat chua--")]public bool is_active= false;
    [Header("--Trang thai nhiem vu--")]public bool is_completed = false;

    //item yeu cau
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
    [Header("--Loi thoai voi NPC--")] public List<string> dialogue;//loi thoai voi npc
    [Header("--Cau truyen voi NPC--")]public string storyLine;//cau truyen
}
