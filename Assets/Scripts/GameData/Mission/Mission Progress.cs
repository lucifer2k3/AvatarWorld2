using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionProgress : MonoBehaviour
{
    public static MissionProgress instance;
    public List<Mission> missions;
    public int main_Phase = 0;
    private void Awake()
    {
        instance= this;
    }
}
[System.Serializable]
public class Mission
{
    public int id;//id nv
    public int phase;
    public string name;//ten
    public string description;//mo ta

    public bool is_active= false;
    public bool is_completed = false;


    //item yeu cau
    public Item req1;
    public Item req2;

    // so luong yeu cau
    public int require1;
    public int require2;

    // tien do nhiem vu
    public int progress1;
    public int progress2;

    //phan thuong
    public Item reward;
    public int quantity;
    public string rewardText;
}
