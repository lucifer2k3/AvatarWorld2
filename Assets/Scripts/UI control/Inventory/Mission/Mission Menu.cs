using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MissionMenu : MonoBehaviour
{

    //panel left

    [SerializeField] private TextMeshProUGUI panel_left_quest_name;

    //panel right
    [SerializeField] private TextMeshProUGUI quest_name;
    [SerializeField] private TextMeshProUGUI quest_description;
    [SerializeField] private TextMeshProUGUI quest_strLine;
    [SerializeField] private TextMeshProUGUI reward;
    [SerializeField] private TextMeshProUGUI req1;


    private void FixedUpdate()
    {
        if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 0)
        {
            //panel trai
            
            
        }
        else
        {
            
        }
        switch (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state)
        {
            case 0:
                panel_left_quest_name.text = "Hiện chưa có nhiệm vụ nào được nhận!";
                quest_name.text = "";
                quest_description.text = "";
                quest_strLine.text = "";
                reward.text = "";
                req1.text = "";
                break;
            case 1:
                panel_left_quest_name.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].name;


                //ten nv
                quest_name.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].name;
                quest_description.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].description;
                quest_strLine.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].storyLine;
                //phan thuong nv
                if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].has_reward == true)
                {
                    reward.text = "Phần thưởng: " + MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].rewardText;
                }
                else
                {
                    reward.text = "";
                }
                //
                if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].item_required == true)
                {
                    //tien do nv
                    req1.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].req_item_name.ToString() + ":"
                        + MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].progress1.ToString() + "/"
                        + MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].require1.ToString();
                }
                else
                {
                    req1.text = "";
                }
                break;
            case 2:
                panel_left_quest_name.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].name;


                //ten nv
                quest_name.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].name;
                quest_description.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].description;
                quest_strLine.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].storyLine;
                //phan thuong nv
                if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].has_reward == true)
                {
                    reward.text = "Phần thưởng: " + MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].rewardText;
                }
                else
                {
                    reward.text = "";
                }

                //
                if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].item_required == true)
                {
                    //tien do nv
                    req1.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].req_item_name.ToString() + ":"
                        + MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].progress1.ToString() + "/"
                        + MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].require1.ToString();
                }
                else
                {
                    req1.text = "";
                }
                break;
        }
    }
}
