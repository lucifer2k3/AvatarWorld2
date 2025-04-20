using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class StoreHouse : MonoBehaviour
{
    public static int House_lv = 1;

    public SpriteRenderer spriteRenderer;
    public SpriteLibrary spriteLibrary;
    private void Update()
    {
        switch (House_lv)
        {
            case 1:
                spriteRenderer.sprite = spriteLibrary.GetSprite("StoreHouse", "LV1");
                break;
            case 2:
                spriteRenderer.sprite = spriteLibrary.GetSprite("StoreHouse", "LV2");
                break;
            case 3:
                // Do something for level 3
                break;
            default:
                Debug.Log("Invalid level");
                break;
        }
    }
}
