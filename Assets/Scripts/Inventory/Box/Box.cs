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
        StorageController.instance.choosingButton = boxPos;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //if (PlayerStats.instance.playerItems[boxPos].item)
        //{
        //    itemImage.color = new Color(255,255,255,255);
        //    itemImage.sprite = PlayerStats.instance.playerItems[boxPos].item.itemImage;
        //    if (PlayerStats.instance.playerItems[boxPos].amount==0 || PlayerStats.instance.playerItems[boxPos].amount == 1)
        //    {
        //        amountText.text = "";
        //    }
        //    else
        //    {
        //        amountText.text = PlayerStats.instance.playerItems[boxPos].amount.ToString();
        //    }
        //}
        //if (PlayerStats.instance.playerItems[boxPos].item == null)
        //{
        //    itemImage.color = new Color(255, 255, 255, 0);
        //    amountText.text = "";
        //}
        
    }
}
