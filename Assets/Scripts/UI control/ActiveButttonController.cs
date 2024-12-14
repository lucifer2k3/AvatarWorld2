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
    private Text amountText;
    void Start()
    {
        activeButton = this.transform.name;
        int startIndex = activeButton.IndexOf('(');
        string numberString = activeButton.Substring(startIndex + 1, activeButton.Length - startIndex - 2);
        activeButtonPos = int.Parse(numberString);
        itemImage = transform.Find("Item Image").GetComponent<Image>();
        amountText = transform.Find("Amount").GetComponent<Text>();
    }

    void FixedUpdate()
    {
        if (posInInvent != -1)
        {

        }
    }
}
