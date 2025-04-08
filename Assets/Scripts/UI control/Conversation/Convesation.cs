using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Convesation : MonoBehaviour
{
    public static Convesation Instance;

    //public int progress;
    public int state = 0;
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
        
    }
    public void AddTalk(List<string> dialogues, List<Sprite> sprites)
    {
        state = 0;
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
        state = 1;
        NPC_dialogue_string.Clear();
        NPC_dialogue_sprite.Clear();
        for (int i = 0; i < dialogues.Count; i++)
        {
            NPC_dialogue_string.Add(dialogues[i]);
            NPC_dialogue_sprite.Add(sprites[i]);
        }
    }
    public void OpenConversation()
    {
        switch (MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state)
        {
            case 0:
                AddConversation(MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].earnquest_dialogue, MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].earnquest_sprite);
                MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].quest_state = 1;
                break;
            case 2:
                AddConversation(MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].completequest_dialogue, MissionProgress.instance.missions[MissionProgress.instance.Player_Mission_Progress].completequest_sprite);
                break;
        }
        main_conversation.SetActive(true);
    }
    public void OpenTalk()
    {
        main_conversation.SetActive(true);
    }
    public void CloseConversation()
    {
        main_conversation.SetActive(false);
    }
}
