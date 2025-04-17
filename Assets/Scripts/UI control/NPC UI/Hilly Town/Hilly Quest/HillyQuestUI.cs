using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HillyQuestUI : MonoBehaviour
{
    [SerializeField] private GameObject quest_Enter_Panel;

    private int STT=0;

    //tro chuyen
    [SerializeField] private List<string> major_conversation;
    [SerializeField] private List<Sprite> major_sprite;
    public void OpenTalk()
    {
        Convesation.Instance.OpenTalk();
        Convesation.Instance.AddTalk(major_conversation, major_sprite);
        quest_Enter_Panel.SetActive(false);
    }


    public void Leave()
    {
        quest_Enter_Panel.SetActive(false);
    }

}
