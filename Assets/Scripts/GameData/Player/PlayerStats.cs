﻿using System.Collections;
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
    private void FixedUpdate()
    {
        if (player_now_energy > 50)
        {
            player_now_energy = 50;
        }
    }
    public void Sleep()
    {
        if (player_now_energy < 25)
        {
            player_now_energy = 20;
        }
    }
    public void Work(int energy)
    {
        if (player_now_energy <= 0)
        {
            MesAndNoti.instance.SetNotification("Bạn đã kiệt sức, hãy nghỉ ngơi hoặc nạp lại năng lượng");
        }
        else
        {
            player_now_energy -= energy;
        }
    }
}
