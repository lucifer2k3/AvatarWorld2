using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Convesation : MonoBehaviour
{
    public static Convesation Instance;
    public Image npc_Image;
    public TextMeshProUGUI npc_conversation;

    [SerializeField] private GameObject conversationUI;
    private void Awake()
    {
        Instance = this;
    }
    public void CloseConversation()
    {
        conversationUI.SetActive(false);
    }
}
