using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestButton : MonoBehaviour
{
    private TextMeshProUGUI quest_name;
    private Button this_Button;
    private void Start()
    {
        quest_name= GetComponentInChildren<TextMeshProUGUI>();
        this_Button = GetComponent<Button>();
        
    }
    private void FixedUpdate()
    {
        quest_name.text = MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].name.ToString();
    }
    public void OnQuestClick()
    {
        MissionMenu.choosing_quest = MissionProgress.instance.Player_Mission_Progress;
    }
}
