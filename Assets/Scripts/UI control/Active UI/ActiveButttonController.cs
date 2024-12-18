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
    private Text amountText;
    void Start()
    {
        activeButton = this.transform.name;
        int startIndex = activeButton.IndexOf('(');
        string numberString = activeButton.Substring(startIndex + 1, activeButton.Length - startIndex - 2);
        activeButtonPos = int.Parse(numberString);
        itemImage = transform.Find("Item Image").GetComponent<Image>();
        amountText = transform.Find("Amount").GetComponent<Text>();
        choosingImage = transform.Find("Choosing Image").GetComponent<Image>();
    }

    void FixedUpdate()
    {
        if (ActiveUI.usingItem == activeButtonPos)
        {
           choosingImage.color = new Color(255, 255, 255, 255);
        }
        if (ActiveUI.usingItem != activeButtonPos)
        {
            choosingImage.color = new Color(255, 255, 255, 0);
        }
        if(ItemBinding.itemBindingForButton[activeButtonPos] <=-1)
        {
            itemImage.color = new Color(255, 255, 255, 0);
            itemImage.sprite = null;
        }
        else
        {
            itemImage.color = new Color(255, 255, 255, 255);
            //itemImage.sprite = PlayerStats.instance.playerItems[ItemBinding.itemBindingForButton[activeButtonPos]].item.itemImage;
        }

    }
}
