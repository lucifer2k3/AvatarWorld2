using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    private void Awake(){
        instance = this;
    }
    public enum itemusing{
        axe,
        seed,
    }
    public itemusing itemsusing;
    public int wood=0;
    public int food;

    public bool tired = false;
    public Text woodRemain;
    void FixedUpdate(){
        woodRemain.text = wood.ToString();
    }

}
