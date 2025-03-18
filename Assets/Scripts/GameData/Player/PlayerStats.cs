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
    //nhan vat
    public float player_Energy = 50;
    public float player_now_energy;


    //tài nguyên

    public int choosingItem = 0;
    public float playerGold = 500;
    private void Awake(){
        instance = this;
    }
    private void Start()
    {
        player_now_energy = player_Energy;
    }
    
    
}
