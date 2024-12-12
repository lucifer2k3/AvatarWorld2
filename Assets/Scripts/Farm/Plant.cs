using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private bool canHavest=false;
    [SerializeField] private Item item;
    private SpriteRenderer plant;
    float growTime;
    void Awake()
    {
        plant = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void OnMouseDown(){
        
    }
}
