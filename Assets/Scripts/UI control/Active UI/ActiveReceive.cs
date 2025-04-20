using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActiveReceive : MonoBehaviour
{
    public static ActiveReceive instance;
    public string Info;
    [SerializeField]private TextMeshProUGUI text;
    private float NotificationTime = 0f;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (NotificationTime >= 0)
        {
            text.color = new Color(42, 42, 42, 255);
            NotificationTime -= Time.deltaTime;
            text.text = Info;
        }
        else
        {
            text.color = new Color(42,42,42,0);
            text.text = "";
        }
    }
    public void ShowInfo(string info)
    {
        Info = info;
        text.color = new Color32(42, 42, 42, 255);
        NotificationTime = 1f;
    }
}
