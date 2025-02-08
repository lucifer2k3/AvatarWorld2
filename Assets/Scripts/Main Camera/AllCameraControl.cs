using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AllCameraControl : MonoBehaviour
{
    public static AllCameraControl instance;

    public CinemachineVirtualCamera farm_Camera;
    public CinemachineVirtualCamera hillyTown_Camera;
    public int playerpos = 0;

    private void Start()
    {
        instance= this;
    }
    private void Update()
    {
        switch (playerpos)
        {
            case 0:
                hillyTown_Camera.Priority = 0;
                farm_Camera.Priority = 1;
            break;
            case 1:
                farm_Camera.Priority = 0;
                hillyTown_Camera.Priority = 1;
            break;
        }
    }
}
