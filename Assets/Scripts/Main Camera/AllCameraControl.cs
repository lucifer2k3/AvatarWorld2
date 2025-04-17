using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[System.Serializable]
public struct CameraPos
{
    public CinemachineVirtualCamera VC;
    public string MapName;
}
public class AllCameraControl : MonoBehaviour
{

    public static int playerpos = 0;
    [Header("black smith store=4;" +
        "farm houselv1=5;" +
        "farmhouselv2=6;" +
        "robert store=2;" +
        "hilly town =1;" +
        "farm =0")]
    public List<CameraPos> camPos;
    private void Start()
    {
        for (int i=0;i<camPos.Count;i++)
        {
            camPos[i].VC.Priority = 0;
        }
        camPos[0].VC.Priority= 1;
    }
    private void FixedUpdate()
    {
        for(int i = 0; i < camPos.Count; i++)
        {
            if (i == playerpos)
            {
                camPos[i].VC.Priority = 1;
            }
            else
            {
                camPos[i].VC.Priority = 0;
            }

        }
    }
}
