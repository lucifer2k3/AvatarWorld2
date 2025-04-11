using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MesAndNoti : MonoBehaviour
{
    public static MesAndNoti instance;

    [SerializeField] private GameObject messagePanel;
    [SerializeField] private GameObject notificationPanel;

    [SerializeField] private TextMeshProUGUI notification;
    [SerializeField] private TextMeshProUGUI message;
    [SerializeField] private TextMeshProUGUI sender;
    private void Awake()
    {
        instance = this;
    }
    public void CloseMessage()
    {
        messagePanel.SetActive(false);
    }
    public void CloseNotification()
    {
        notificationPanel.SetActive(false);
    }
    public void SetMessage(string str)
    {
        message.text = str;
        messagePanel.SetActive(true);
    }
    public void SetNotification(string str)
    {
        notification.text = str;
        notificationPanel.SetActive(true);
    }
}
