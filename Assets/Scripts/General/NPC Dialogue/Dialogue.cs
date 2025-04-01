using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{

    [SerializeField]private List<NPC_Dialogue> NPC_Dialogues;

    [SerializeField] private GameObject MainDialogue;
    [SerializeField] private GameObject UI_Enter_Panel;
    public void EnterDialogue()
    {
        Convesation.Instance.AddConversation(NPC_Dialogues[0].dialogueList, NPC_Dialogues[0].dialogueSpriteList);
        UI_Enter_Panel.SetActive(false);
        MainDialogue.SetActive(true);
    }
    public void EnterTalk()
    {
        Convesation.Instance.AddConversation(NPC_Dialogues[0].dialogueList, NPC_Dialogues[0].dialogueSpriteList);  
        UI_Enter_Panel.SetActive(false);
        MainDialogue.SetActive(true);
    }
}
[System.Serializable]
public class NPC_Dialogue
{
     public List<string> dialogueList;
     public List<Sprite> dialogueSpriteList;
}
