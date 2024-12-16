using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageController : MonoBehaviour
{
    public static StorageController instance;
    [SerializeField] private Button dropButton;
    [SerializeField] private Button bindButton;
    [SerializeField] private GameObject BindUI;
    public int choosingButton=-1;

    public ActiveUI activeUI;
    private void Awake()
    {
        instance = this;
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
