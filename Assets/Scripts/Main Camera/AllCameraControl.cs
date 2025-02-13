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
    public CinemachineVirtualCamera farm_house;
   
    public static int playerpos = 0;//(farm house = 3; robert store =2 hilly town =1; farm =0)


    private void Start()
    {    }
    private void Update()
    {
        // priority = 1 -> do uu tien camera cua map day = 1
        switch (playerpos)
        {
            case 0:
                farm_house.Priority = 0;
                hillyTown_Camera.Priority = 0;
                robertStore_Camera.Priority = 0;
                farm_Camera.Priority = 1;
            break;
            case 1:
                farm_house.Priority = 0;
                farm_Camera.Priority = 0;
                robertStore_Camera.Priority = 0;
                hillyTown_Camera.Priority = 1;
            break;
            case 2:
                farm_house.Priority = 0;
                farm_Camera.Priority = 0;
                hillyTown_Camera.Priority = 0;
                robertStore_Camera.Priority = 1;

            break;
            case 3:
                farm_Camera.Priority = 0;
                hillyTown_Camera.Priority = 0;
                robertStore_Camera.Priority = 0;
                farm_house.Priority = 1;
                break;

        }
    }
}
