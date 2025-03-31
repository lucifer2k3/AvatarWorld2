using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField]private List<NPC_Dialogue> NPC_Dialogues;
    public void EnterDialogue()
    {
        Convesation.Instance.AddConversation(NPC_Dialogues[0].dialogueList, NPC_Dialogues[0].dialogueSpriteList);
    }
}
[System.Serializable]
public class NPC_Dialogue
{
     public List<string> dialogueList;
     public List<Sprite> dialogueSpriteList;
}
