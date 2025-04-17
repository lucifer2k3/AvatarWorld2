using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenUI : MonoBehaviour
{
    [SerializeField] private GameObject cookUI;

    public static int choosing_Item = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (choosing_Item != -1)
        {
            // Update the UI with the selected item
            // For example, you can set the item name, image, etc.
        }
        else
        {
            // Clear the UI when no item is selected
        }
    }
    public void CloseCookUI()
    {
        cookUI.SetActive(false);
    }
}
public struct CookingRecipes
{
    public Item cooking_item1;
    public int item1_quantity;
    public Item cooking_item2;
    public int item2_quantity;
    public Item cooking_out;
    public int out_quantity;
}
