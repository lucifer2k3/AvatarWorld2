using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    public float speed = 5f;
    [SerializeField]public Sprite[] itemImage;
    [SerializeField]public Image usingItemImage;
    Vector2 move;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        move = new Vector2 (Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        move.Normalize();
        

        animator.SetFloat("Horizontal",move.x);
        animator.SetFloat("Vertical",move.y);
        animator.SetFloat("Speed",move.sqrMagnitude);
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            PlayerStats.instance.itemsusing = PlayerStats.itemusing.axe;
            usingItemImage.sprite = itemImage[0];
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            PlayerStats.instance.itemsusing = PlayerStats.itemusing.seed;
            usingItemImage.sprite = itemImage[1];
        }
    }
    void FixedUpdate(){
        rb.MovePosition(rb.position+move*speed*Time.deltaTime);
    }
}
