using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    private Animator anim;


    private Animator weapon_anim;
    private Animator weapon_left_anim;

    private Rigidbody2D rb;

    public float speed = 5f;
    private bool Moving;

    private Vector2 input;

    private float x;
    private float y;

    void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        weapon_anim = transform.Find("Weapon Animation").GetComponent<Animator>();
        weapon_left_anim = transform.Find("Weapon Animation Left").GetComponent<Animator>();
    }

    
    void Update()
    {
        GetInput();
        Animate();
    }
    void FixedUpdate()
    {
        rb.velocity = input * speed;
    }
    private void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        input = new Vector2(x,y);
        input.Normalize();
    }
    private void Animate()
    {
        if (input.magnitude > 0.1f || input.magnitude < -0.1f)
        {
            Moving = true;
        }
        else
        {
            Moving = false;
        }
        if (Moving)
        {
            anim.SetFloat("x", x);
            anim.SetFloat("y", y);
        }
        anim.SetBool("IsMoving", Moving);
    }
    public void axetrigger(bool left)
    {
        switch (left)
        {
            case true:
                weapon_left_anim.SetTrigger("Weapon Trigger");
                weapon_left_anim.SetInteger("State", 1);
                break;
            case false:
                weapon_anim.SetTrigger("Weapon Trigger");
                weapon_anim.SetInteger("State", 1);
                break;
        }
    }
}
