using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;


    public bool tired = false;
    public int choosingItem = 0; 
    private void Awake(){
        instance = this;
    }
    private void Start()
    {
    }
    
    
}
