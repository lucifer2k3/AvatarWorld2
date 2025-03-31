using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainConver : MonoBehaviour
{
    public static MainConver Instance;
    public Image npcImageRight;
    public TextMeshProUGUI npc_conversation;

    public List<string>NPC_Dialogue;
    public List<Sprite> NPC_Dialogue_Sprite;

    //dialogue UI
    public GameObject dialogue;
    //stt
    private int STT;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (dialogue.activeInHierarchy)
        {
            npc_conversation.text = NPC_Dialogue[STT];
            npcImageRight.sprite = NPC_Dialogue_Sprite[STT];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (NPC_Dialogue.Count - 1 > STT)
                {
                    STT++;
                }
                else
                {
                    // nhan nv
                    gameObject.SetActive(false);
                    //thisthis.SetActive(false);
                    MissionProgress.instance.Player_Mission_Progress++;
                    STT = 0;
                }
            }
        }
    }
    private void OnEnable()
    {
        ResetDialogue(MissionProgress.instance.Player_Mission_Progress);
    }
    private void OnDisable()
    {
        STT = 0;
    }
    public void ResetDialogue(int Quest)
    {
        NPC_Dialogue.Clear();
        NPC_Dialogue_Sprite.Clear();
        for (int i = 0; i < MissionProgress.instance.missions[Quest].dialogue.Count; i++)
        {
            NPC_Dialogue.Add(MissionProgress.instance.missions[Quest].dialogue[i]);
            NPC_Dialogue_Sprite.Add(MissionProgress.instance.missions[Quest].dialogueAvatar[i]);
        }
    }
}
