using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActiveUI : MonoBehaviour
{
    public static int usingItem = 0;
    public static int id = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            usingItem = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            usingItem = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            usingItem = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            usingItem = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            usingItem = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            usingItem = 5;
        }
    }
}
