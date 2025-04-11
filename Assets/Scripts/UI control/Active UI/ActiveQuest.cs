using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ActiveQuest : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI quest_name;
    [SerializeField] private TextMeshProUGUI quest_description;


    // Update is called once per frame
    private void FixedUpdate()
    {
        if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 0)
        {
            quest_name.text = "Hiện chưa có nhiệm vụ";
            switch(MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].npc_name.ToString())
            {
                case "Robert":
                    quest_description.text = "Hãy gặp " + "Robert" + " để nhận nhiệm vụ";
                    break;
                case "Caroline":
                    quest_description.text = "Hãy gặp " + "Caroline" + " để nhận nhiệm vụ";
                    break;
                case "Major":
                    quest_description.text = "Hãy gặp " + "Thị trưởng" + " để nhận nhiệm vụ";
                    break;
                case "BlackSmith":
                    quest_description.text = "Hãy gặp " + "Thợ rèn" + " để nhận nhiệm vụ";
                    break;
            }
            return;
        }
        else
        {
            quest_name.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].name;
            quest_description.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].description;
        }
    }
}
