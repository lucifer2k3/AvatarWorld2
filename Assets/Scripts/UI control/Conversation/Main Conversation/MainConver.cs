using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainConver : MonoBehaviour
{
    public MainConver Instance { get; private set; }

    public Image npcImageRight;
    public TextMeshProUGUI npc_conversation;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            npc_conversation.text = Convesation.Instance.NPC_dialogue_string[Convesation.Instance.STT];
            npcImageRight.sprite = Convesation.Instance.NPC_dialogue_sprite[Convesation.Instance.STT];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Convesation.Instance.NPC_dialogue_string.Count - 1 > Convesation.Instance.STT)
                {
                    Convesation.Instance.STT++;
                }
                else
                {
                    // nhan nv
                    gameObject.SetActive(false);
                    if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 0) 
                    { 
                        MissionProgress.instance.TakeQuest();
                    }
                    if (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state == 2) 
                    {
                        //print("test");
                        MissionProgress.instance.CompleteQuest();
                    }
                    Convesation.Instance.STT = 0;
                }
            }
        }
    }
    public void CloseConversation()
    {
        gameObject.SetActive(false);
    }
    
    
}
