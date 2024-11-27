using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public Transform transformer;
    private Transform player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(){
        player.position = transformer.position;
    }
    void Teleport(){

    }
}
