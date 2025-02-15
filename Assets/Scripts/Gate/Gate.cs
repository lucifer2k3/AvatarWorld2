using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private Transform way_out;
    [SerializeField]private GameObject player;
    public int mapCode;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<GameObject>();
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
