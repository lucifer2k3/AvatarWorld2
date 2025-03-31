using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    [SerializeField] private int value=0;
    private void Awake()
    {
        Application.targetFrameRate= value;
    }
}
