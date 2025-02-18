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
        if (this.transform.name != "-1") 
        { 
            quest_name.text = MissionProgress.instance.missions[int.Parse(this.transform.name)].name.ToString();
        }
    }
}
