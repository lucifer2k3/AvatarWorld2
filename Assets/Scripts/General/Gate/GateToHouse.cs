using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateToHouse : MonoBehaviour
{
    [Header("blacksmithstore=4;farmhouseLV1=5;farmhouseLV2=6;robertstore=2;hillytown=1;farm=0)")]
    [SerializeField] private Transform HouseLV1_way_out;
    [SerializeField] private Transform HouseLV2_way_out;


    private Transform player;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (FarmHouse.instance.HouseLevel == 1)
            {
                AllCameraControl.playerpos = 5;
                player.transform.position = HouseLV1_way_out.position;
            }
            if (FarmHouse.instance.HouseLevel == 2)
            {
                AllCameraControl.playerpos = 6;
                player.transform.position = HouseLV2_way_out.position;
            }
        }
    }
}
