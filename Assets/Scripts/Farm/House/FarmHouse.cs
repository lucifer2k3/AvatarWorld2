using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class FarmHouse : MonoBehaviour
{
    public static FarmHouse instance;
    public int HouseLevel = 2;
    [SerializeField]private SpriteLibrary spriteLibrary;
    [SerializeField]private SpriteRenderer spriteRenderer;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (HouseLevel)
        {
            
            case 1:
                spriteRenderer.sprite = spriteLibrary.GetSprite("House", "LV1");
                // Do something for level 0

                break;
            case 2:
                spriteRenderer.sprite = spriteLibrary.GetSprite("House", "LV2");
                // Do something for level 1
                break;
            case 3:
                // Do something for level 2
                break;
            
        }
    }
}
