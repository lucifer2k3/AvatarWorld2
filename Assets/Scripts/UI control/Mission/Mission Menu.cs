using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MissionMenu : MonoBehaviour
{
    public GameObject missionButton;
    public GameObject content;
    public List<GameObject> items = new List<GameObject>();
    public List<TextMeshProUGUI> item_text = new List<TextMeshProUGUI>();
    void Start()
    {

        missionButton.SetActive(false);
        for (int i = 0; i < MissionProgress.instance.missions.Count; i++)
        {
            items.Add (Instantiate(missionButton));
            items[i].transform.name = i.ToString();
            items[i].transform.parent = content.transform;
            items[i].SetActive(false);

        }
    }
    private void OnEnable()
    {
        if (items.Count>0){
            for (int i = 0; i < MissionProgress.instance.missions.Count; i++)
            {
                if (MissionProgress.instance.missions[i].is_active)
                {
                    items[i].SetActive(true);
                }
                else
                {
                    items[i].SetActive(false);
                }
            }
        }
    }
}
