using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ActiveButttonController : MonoBehaviour
{
    private string activeButton;
    private int activeButtonPos;
    public static int posInInvent=-1;
    private Image itemImage;
    private Image choosingImage;

    void Start()
    {
        activeButton = this.transform.name;
        int startIndex = activeButton.IndexOf('(');
        string numberString = activeButton.Substring(startIndex + 1, activeButton.Length - startIndex - 2);
        activeButtonPos = int.Parse(numberString);
        itemImage = transform.Find("Item Image").GetComponent<Image>();
        choosingImage = transform.Find("Choosing Image").GetComponent<Image>();
    }

    void FixedUpdate()
    {
        if (ItemBinding.instance.usingItem == activeButtonPos)
        {
           choosingImage.color = new Color(255, 255, 255, 255);
        }
        if (ItemBinding.instance.usingItem != activeButtonPos)
        {
            choosingImage.color = new Color(255, 255, 255, 0);
        }
        if (ItemBinding.instance.posInInvent[activeButtonPos] <= -1)
        {
            itemImage.color = new Color(255, 255, 255, 0);
            itemImage.sprite = null;
        }
        else
        {
            if (PlayerInvent.instance.item[ItemBinding.instance.posInInvent[activeButtonPos]])
            {
                itemImage.color = new Color(255, 255, 255, 255);
                itemImage.sprite = PlayerInvent.instance.item[ItemBinding.instance.posInInvent[activeButtonPos]].itemImage;
            }
            else
            {
                itemImage.color = new Color(255, 255, 255, 0);
                itemImage.sprite = null;
            }
        }

    }
}
