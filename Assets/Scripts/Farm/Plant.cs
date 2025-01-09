using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Plant : MonoBehaviour
{
    public Item itemWhenHavest;

    private SpriteRenderer state;      //dung khi can
    private SpriteRenderer thistree;    // hinh anh cua cay
    private SpriteLibrary library;      // thu vien anh dung khi cay lon

    private Tile parentTile;
    public enum plantTypes
    {
        canHavestTree,
        woodTree,
        grass
    }

    public int growPhase = 1; 
    public float[] growTimes = new float[6];
    public float growTime=0;
    public float boost = 1;


    private bool canHavest = false;

    void Start()
    {
        library = GetComponent<SpriteLibrary>();
        thistree = GetComponent<SpriteRenderer>();
        growTime = growTimes[0];
        thistree.sprite = library.GetSprite("Grow Phase", "p1");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (canHavest)
            {
                print("havested");
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnMouseDown()
    {
        if (canHavest)
        {
            PlayerInvent.instance.AddItem(itemWhenHavest, 3);
            parentTile = transform.parent.GetComponent<Tile>();
            parentTile.isPlanted = false;
            Destroy(gameObject);

        }
    }
    void FixedUpdate()
    {
        switch (growPhase)
        {
            case 1:
                if (growTime>0)
                {
                    growTime -= Time.deltaTime * boost;
                    break;
                }
                if (growTime <= 0)
                {
                    growTime = growTimes[1];
                    growPhase = 2;
                    thistree.sprite = library.GetSprite("Grow Phase", "p2");
                    break;
                }
                break;
            case 2:
                if (growTime>0)
                {
                    growTime -= Time.deltaTime * boost;
                    break;
                }
                if (growTime <= 0)
                {
                    growTime = growTimes[2];
                    growPhase = 3;
                    thistree.sprite = library.GetSprite("Grow Phase", "p3");
                    break;
                }
                break;
            case 3:
                if (growTime>0)
                {
                    growTime -= Time.deltaTime * boost;
                    break;
                }
                if (growTime <= 0)
                {
                    growTime = growTimes[3];
                    growPhase = 4;
                    thistree.sprite = library.GetSprite("Grow Phase", "p4");
                    break;
                }
                break;
            case 4:
                if (growTime>0)
                {
                    growTime -= Time.deltaTime * boost;
                    break;
                }
                if (growTime <= 0)
                {
                    growTime = growTimes[4];
                    growPhase = 5;
                    thistree.sprite = library.GetSprite("Grow Phase", "p5");
                    break;
                }
                break;
            case 5:
                if (growTime>0)
                {
                    growTime -= Time.deltaTime * boost;
                    break;
                }
                if (growTime <= 0)
                {
                    growTime = growTimes[5];
                    growPhase = 6;
                    thistree.sprite = library.GetSprite("Grow Phase", "p6");
                    canHavest = true;
                    break;
                }
                break;
        }
    }
    
}
