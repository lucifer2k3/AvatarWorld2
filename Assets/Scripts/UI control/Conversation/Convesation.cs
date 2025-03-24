using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Convesation : MonoBehaviour
{
    

    [SerializeField] private GameObject conversationUI;

    public void CloseConversation()
    {
        conversationUI.SetActive(false);
    }
}
