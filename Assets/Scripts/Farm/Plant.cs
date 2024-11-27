using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private bool canHavest=false;
    public Sprite[] growphase = new Sprite[7];
    private SpriteRenderer plant;
    float growTime = 14f;
    void Start()
    {
        plant = GetComponent<SpriteRenderer>();
        plant.sprite = growphase[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (growTime>=0){
            growTime -= Time.deltaTime;
        }
        if (growTime<12){
            plant.sprite = growphase[0];
        }
        if (growTime<10){
            plant.sprite = growphase[1];
        }
        if (growTime<8){
            plant.sprite = growphase[2];
        }
        if (growTime<6){
            plant.sprite = growphase[3];
        }
        if (growTime<4){
            plant.sprite = growphase[4];
        }
        if (growTime<2){
            plant.sprite = growphase[5];
        }
        if (growTime<0.01){
            plant.sprite = growphase[6];
            canHavest=true;
        }
    }
    void OnMouseDown(){
        if (canHavest==true){
            print("bạn vừa thu hoạch cải tím");
            Destroy(gameObject);
        }
    }
}
