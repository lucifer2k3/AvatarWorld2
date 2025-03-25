using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainConver : MonoBehaviour
{
    public static MainConver Instance;
    public Image npc_Image;
    public TextMeshProUGUI npc_conversation;

    [Header("0= major,1= caroline")][SerializeField] private List<Sprite> Npc_Avatar;
    public List<string>NPC_Dialogue;

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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (NPC_Dialogue.Count - 1 > STT)
                {
                    STT++;
                }
                else
                {
                    // nhan nv
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
        npc_Image.sprite = null;
        for (int i = 0; i < MissionProgress.instance.missions[Quest].dialogue.Count; i++)
        {
            NPC_Dialogue.Add(MissionProgress.instance.missions[Quest].dialogue[i]);
        }
    }
}
