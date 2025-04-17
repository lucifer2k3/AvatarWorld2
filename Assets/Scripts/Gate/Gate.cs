using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // (chi so playerpos duoc chinh o file gate.cs)
    [Header("farm=0;hillytown=1;robertstore=2;communitycenter=3;blacksmithstore=4;farmhouse1=5;farmhouse2=6;hillyForest=7;hillyQuarry=8")] 
    [SerializeField]private Transform way_out;
    private Transform player;
    public int mapCode;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            AllCameraControl.playerpos = mapCode;
            player.transform.position = way_out.position;
        }
    }
}
