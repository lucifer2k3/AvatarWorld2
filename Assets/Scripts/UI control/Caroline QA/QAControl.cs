using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAControl : MonoBehaviour
{
    [SerializeField] private GameObject QA_Main;
    [SerializeField] private GameObject QA_enter_panel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OpenQAMain()
    {
        QA_Main.SetActive(true);
        QA_enter_panel.SetActive(false);
    }
    public void Close_QA_Enter_Panel()
    {
        QA_enter_panel.SetActive(false);
    }public void Close_QA_()
    {
        QA_Main.SetActive(false);
    }
}
