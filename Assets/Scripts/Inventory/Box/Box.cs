using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    private string box;
    private int boxPos;
    private Image itemImage;
    private Text amountText;
    void Awake()
    {
        box = this.transform.name;
        int startIndex = box.IndexOf('(');
        string numberString = box.Substring(startIndex + 1, box.Length - startIndex - 2);
        boxPos = int.Parse(numberString);
        itemImage = transform.Find("Item Image").GetComponent<Image>();
        amountText = transform.Find("Amount Text").GetComponent<Text>();
    }
    public void ShowBoxInfo()
    {
        if (PlayerInvent.instance.item[boxPos])
        {
            
            StorageController.instance.choosingButton = boxPos;
        }
            
    }
    

    void FixedUpdate()
    {
        if (PlayerInvent.instance.item[boxPos])
        {
            itemImage.color = new Color(255, 255, 255, 255);
            itemImage.sprite = PlayerInvent.instance.item[boxPos].itemImage;
            if (PlayerInvent.instance.item[boxPos].amount == 0 || PlayerInvent.instance.item[boxPos].amount == 1)
            {
                amountText.text = "";
            }
            else
            {
                amountText.text =PlayerInvent.instance.item[boxPos].amount.ToString();
            }
        }
        if (PlayerInvent.instance.item[boxPos] == null)
        {
            itemImage.color = new Color(255, 255, 255, 0);
            itemImage.sprite = null;
            amountText.text = "";
        }

    }
    public void PointerDown()
    {

    }
    public void PointerEnter()
    {
        
    }
    public void PointerExit()
    {
        
    }
}
