using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Convesation : MonoBehaviour
{
    public static Convesation Instance;

    public int progress;

    public List<string> NPC_dialogue_string;
    public List<Sprite> NPC_dialogue_sprite;

    public string NPC_talk_string;
    public Sprite NPC_talk_sprite;
    public int STT;
    

    [SerializeField] private GameObject main_conversation;
    private void Awake()
    {
        Instance= this;
    }
    private void FixedUpdate()
    {
        switch (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state)
        {
            case 0:
                if (progress != MissionProgress.instance.Player_Mission_Progress)
                {
                    AddConversation(AllDialogue.instance.robert_dialogue[MissionProgress.instance.Player_Mission_Progress].dialogue,
                        AllDialogue.instance.robert_dialogue[MissionProgress.instance.Player_Mission_Progress].dialogue_sprite);
                    progress = MissionProgress.instance.Player_Mission_Progress;
                }
                break;
            
            case 2:
                break;
        }
        }
    public void AddTalk(List<string> dialogues, List<Sprite> sprites)
    {
        NPC_dialogue_string.Clear();
        NPC_dialogue_sprite.Clear();
        for (int i = 0; i < dialogues.Count; i++)
        {
            NPC_dialogue_string.Add(dialogues[i]);
            NPC_dialogue_sprite.Add(sprites[i]);
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
        main_conversation.SetActive(false);
    }
}
