using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StorageController : MonoBehaviour
{
    public static StorageController instance;

    [SerializeField] private GameObject dropButton;
    [SerializeField] private GameObject bindButton;
    [SerializeField] private GameObject BindUI;
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemDescription;

    public int choosingButton=-1;

    private void Awake()
    {
        instance = this;
    }
    private void FixedUpdate()
    {
        if (choosingButton != -1)
        {
            dropButton.SetActive(true);
            bindButton.SetActive(true);
            itemName.text = PlayerInvent.instance.item[choosingButton].itemName;
            itemDescription.text = PlayerInvent.instance.item[choosingButton].itemDes;
        }
        if (choosingButton == -1)
        {
            BindUI.SetActive(false);
            dropButton.SetActive(false);
            bindButton.SetActive(false);
            itemName.text = null;
            itemDescription.text = null;
        }
    }
    public void Drop()
    {

    }
    public void Bind()
    {
        BindUI.SetActive(true);
    }
    public void QuitBindUI()
    {
        BindUI.SetActive(false);
    }
    public void ShowItemInformation()
    {

    }
}
