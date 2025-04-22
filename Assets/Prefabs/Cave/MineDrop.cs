using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineDrop : MonoBehaviour
{
    [SerializeField]private int dropAmount = 2;
    [SerializeField]private Item DropItem;
    [SerializeField] private int HP = 6;

    private Transform playerPos;
    private void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        if (playerPos == null)
        {
            Debug.LogError("Player not found");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (Vector2.Distance(playerPos.position,this.transform.position)<5f){
            PlayerStats.instance.Work(1);
            if (HP > 0)
            {
                HP--;
            }
            else
            {
                PlayerInvent.instance.AddItem(DropItem, 1);
                Destroy(gameObject);
            }
        }
        else
        {
            print("Too far away");
        }
    }
}
