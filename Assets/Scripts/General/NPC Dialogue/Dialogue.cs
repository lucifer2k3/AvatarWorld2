using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private int[] quest_order = { 0,0,0,0};
    public GameObject Earn_quest_button;
    private void OnEnable()
    {
        for (int i=0;i<quest_order.Length;i++)
        {
            if (quest_order[i] == MissionProgress.instance.Player_Mission_Progress)
            {
                Earn_quest_button.SetActive(true);
                return;
            }
        }
        Earn_quest_button.SetActive(false);
    }
}
