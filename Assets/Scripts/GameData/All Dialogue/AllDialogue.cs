using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDialogue : MonoBehaviour
{
    public List<Dialogue> dialogues;
  
}
[System.Serializable]
public class Dialogue
{
    public int STT_NV;

    [Header("--NV nay co phai nhan khong hay tu dong nhan--")] public bool quest_claimable = false;

    [Header("--Loi thoai voi npc khi noi chuyen--")] public List<string> talk_dialogue;//loi thoai voi npc khi noi chuyen
    public Sprite talk_dialogue_sprite;

    [Header("--Loi thoai voi NPC--")] public List<string> dialogue;//loi thoai voi npc
    public List<Sprite> dialogue_sprite;//avtar khi noi chuyen voi npc

    [Header("--Loi thoai vs NPC khi xong NV--")] public List<string> quest_complete_dialogue;
    public List<Sprite> quest_complete_dialogue_sprite;
}
