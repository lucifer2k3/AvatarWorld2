using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HillyQuestUI : MonoBehaviour
{
    [SerializeField] private GameObject quest_Enter_Panel;
    [SerializeField] private GameObject dialogue;

    private int STT=0;

    void Start()
    {
        
    }


    public void Leave()
    {
        quest_Enter_Panel.SetActive(false);
    }
    public void EarnQuest()
    {
        Leave();
        dialogue.SetActive(true);
    }

}
