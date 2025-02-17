using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
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
