using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActiveUI : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ItemBinding.instance.usingItem = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ItemBinding.instance.usingItem = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ItemBinding.instance.usingItem = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ItemBinding.instance.usingItem = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ItemBinding.instance.usingItem = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ItemBinding.instance.usingItem = 5;
        }
    }
}
