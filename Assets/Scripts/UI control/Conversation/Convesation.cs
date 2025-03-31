using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Convesation : MonoBehaviour
{
    public static Convesation Instance;

    [SerializeField] private GameObject conversationUI;

    public Image npcImageRight;
    public TextMeshProUGUI npc_conversation;

    public List<string> NPC_dialogue_string;
    public List<Sprite> NPC_dialogue_sprite;
    private int STT;
    private void Awake()
    {
        Instance= this;
    }
    
    private void Update()
    {
        if (conversationUI.activeInHierarchy)
        {
            npc_conversation.text = NPC_dialogue_string[STT];
            npcImageRight.sprite = NPC_dialogue_sprite[STT];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (NPC_dialogue_string.Count - 1 > STT)
                {
                    STT++;
                }
                else
                {
                    // nhan nv
                    gameObject.SetActive(false);
                    //MissionProgress.instance.Player_Mission_Progress++;
                    STT = 0;
                }
            }
        }
    }
    public void AddConversation(List<string> dialogues,List<Sprite> sprites)
    {
        NPC_dialogue_string.Clear();
        NPC_dialogue_sprite.Clear();
        for (int i = 0; i < dialogues.Count; i++)
        {
            NPC_dialogue_string.Add(dialogues[i]);
            NPC_dialogue_sprite.Add(sprites[i]);
        }
    }
    public void CloseConversation()
    {
        conversationUI.SetActive(false);
    }
}
