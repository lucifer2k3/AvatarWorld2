using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HillyQuestUI : MonoBehaviour
{
    [SerializeField] private GameObject quest_Enter_Panel;
    [SerializeField] private GameObject dialogue;

    [SerializeField] public TextMeshProUGUI HoiThoai;
    private int STT=0;

    public List<NPCDialogue> npc_Dialogue;
    void Start()
    {
        
    }

    void Update()
    {

        if (dialogue.active)
        {
            HoiThoai.text = npc_Dialogue[0].Dialogue[STT];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (npc_Dialogue[0].Dialogue.Count-1 > STT)
                {
                    STT++;
                }
                else
                {
                    //nhan nv o day
                    STT = 0;
                }
            }
        }
    }
    //loi thoai nhan vat
    [System.Serializable]public class NPCDialogue
    {
        public List<string> Dialogue;
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
