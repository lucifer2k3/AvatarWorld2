using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    private Image energy_remain;
    private void Awake()
    {
        energy_remain = GetComponent<Image>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        energy_remain.fillAmount = PlayerStats.instance.player_now_energy / PlayerStats.instance.player_Energy;
    }
}
