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
    [SerializeField] private GameObject missionButton;
    [SerializeField] private GameObject content;

    //panel right
    [SerializeField] private TextMeshProUGUI quest_name;
    [SerializeField] private TextMeshProUGUI quest_description;
    [SerializeField] private TextMeshProUGUI reward_text;
    [SerializeField] private TextMeshProUGUI reward;
    [SerializeField] private TextMeshProUGUI req1;
    [SerializeField] private TextMeshProUGUI req2;
    [SerializeField] private GameObject claim_reward_button;

    public static int choosing_quest = -1;


    public List<GameObject> items = new List<GameObject>();
    // public List<TextMeshProUGUI> item_text = new List<TextMeshProUGUI>();
    void Start()
    {

        missionButton.SetActive(false);
        for (int i = 0; i < MissionProgress.instance.missions.Count; i++)
        {
            items.Add (Instantiate(missionButton));
            items[i].transform.name = i.ToString();
            items[i].transform.parent = content.transform;
            items[i].SetActive(false);

        }
    }

    //
    private void FixedUpdate()
    {
        if (choosing_quest != -1)
        {
            //ten nv
            quest_name.text = MissionProgress.instance.missions[choosing_quest].name;
            quest_description.text = MissionProgress.instance.missions[choosing_quest].description;

            //phan thuong nv
            reward_text.text = "Phần Thưởng:";
            reward.text = MissionProgress.instance.missions[choosing_quest].rewardText;

            //tien do nv
            req1.text = MissionProgress.instance.missions[choosing_quest].req1.itemName.ToString() + ":"
                + MissionProgress.instance.missions[choosing_quest].progress1.ToString() + "/"
                + MissionProgress.instance.missions[choosing_quest].require1.ToString() ;
            req2.text = MissionProgress.instance.missions[choosing_quest].req2.itemName.ToString() + ":"
                + MissionProgress.instance.missions[choosing_quest].progress2.ToString() + "/"
                + MissionProgress.instance.missions[choosing_quest].require2.ToString() ;

            //nut nhan thuong
            claim_reward_button.SetActive(true);

        }
        else
        {
            quest_name.text = "";
            quest_description.text = "";
            reward_text.text = "";
            reward.text = "";
            req1.text = "";
            req2.text = "";
            claim_reward_button.SetActive(false);
        }
        if (items.Count > 0)
        {
            for (int i = 0; i < MissionProgress.instance.missions.Count; i++)
            {
                if (MissionProgress.instance.missions[i].is_active)
                {
                    items[i].SetActive(true);
                }
                else
                {
                    items[i].SetActive(false);
                }
            }
        }
    }
    public void CompleteQuest() 
    {
        if (MissionProgress.instance.missions[choosing_quest].progress1 == MissionProgress.instance.missions[choosing_quest].require1
            && MissionProgress.instance.missions[choosing_quest].progress2 == MissionProgress.instance.missions[choosing_quest].require2)
        {
            PlayerInvent.instance.AddItem(MissionProgress.instance.missions[choosing_quest].reward, MissionProgress.instance.missions[choosing_quest].quantity);
            choosing_quest = -1;
        }
    }
}
