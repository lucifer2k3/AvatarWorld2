using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MesAndNoti : MonoBehaviour
{
    public static MesAndNoti instance;



    [SerializeField] private TextMeshProUGUI notification;
    [SerializeField] private TextMeshProUGUI message;
    private void Awake()
    {
        instance = this;
    }
    public void CloseMessage()
    {
        gameObject.SetActive(false);
    }
    public void CloseNotification()
    {
        gameObject.SetActive(false);
    }
    public void SetMessage(string str)
    {
        message.text = str;
    }
    public void SetNotification(string str)
    {
        notification.text = str;
    }
}
