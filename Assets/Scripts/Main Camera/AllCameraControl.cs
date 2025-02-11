using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AllCameraControl : MonoBehaviour
{

    public CinemachineVirtualCamera farm_Camera;
    public CinemachineVirtualCamera hillyTown_Camera;
    public CinemachineVirtualCamera robertStore_Camera;
    public static int playerpos = 0;

    private void Start()
    {    }
    private void Update()
    {
        switch (playerpos)
        {
            case 0:
                hillyTown_Camera.Priority = 0;
                robertStore_Camera.Priority = 0;
                farm_Camera.Priority = 1;
            break;
            case 1:
                farm_Camera.Priority = 0;
                robertStore_Camera.Priority = 0;
                hillyTown_Camera.Priority = 1;
            break;
            case 2:
                farm_Camera.Priority = 0;
                hillyTown_Camera.Priority = 0;
                robertStore_Camera.Priority = 1;

                break;
        }
    }
}
