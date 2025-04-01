using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Convesation : MonoBehaviour
{
    public static Convesation Instance;

    public List<string> NPC_dialogue_string;
    public List<Sprite> NPC_dialogue_sprite;
    public int STT;
    private void Awake()
    {
        Instance= this;
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
}
