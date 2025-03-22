using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AllCameraControl : MonoBehaviour
{

    public static int playerpos = 0;// (chi so playerpos duoc chinh o file gate.cs)//(black smith store=4;farm house = 3; robert store =2 hilly town =1; farm =0)
    public int camera_Now_Pos = 0;


    public List<CinemachineVirtualCamera> VC;
    private void Start()
    {
        for (int i=0;i<VC.Count;i++)
        {
            VC[i].Priority = 0;
        }
        VC[0].Priority= 1;
    }
    private void FixedUpdate()
    {
        if (playerpos != camera_Now_Pos)
        {
            VC[camera_Now_Pos].Priority= 0;
            VC[playerpos].Priority= 1;
            camera_Now_Pos = playerpos;
        }
    }
}
