using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ActiveQuest : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI quest_name;
    [SerializeField] private TextMeshProUGUI quest_description;


    // Update is called once per frame
    void Update()
    {
        if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].is_active)
        {
            quest_name.text = "Hiện chưa có nhiệm vụ";
            quest_description.text = "";
            return;
        }
        else
        {
            quest_name.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].name;
            quest_description.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].description;
        }
    }
}
