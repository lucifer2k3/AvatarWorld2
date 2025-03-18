using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftMenuControl : MonoBehaviour
{
    public static CraftMenuControl Instance;
    public int choosing_Item=-1;

    // panel right
    [SerializeField] private TextMeshProUGUI item_Name;
    [SerializeField] private TextMeshProUGUI recipes_text;

    [SerializeField] private Image crafting_image1;
    [SerializeField] private Image crafting_image2;

    //craft recipes
    [SerializeField] private List<CraftingRecipes> craftingRecipes;
    void Awake()
    {
        Instance= this;
    }

    
    void FixedUpdate()
    {
        if (choosing_Item != -1)
        {
            item_Name.text = craftingRecipes[choosing_Item].crafting_out.itemName;
            crafting_image1.sprite = craftingRecipes[choosing_Item].crafting_item1.itemImage;
            crafting_image2.sprite = craftingRecipes[choosing_Item].crafting_item2.itemImage;
        }
        else
        {
            item_Name.text = "";
            crafting_image1.sprite = null;
            crafting_image2.sprite = null;
        }
    }
    //crafting recipes
    [System.Serializable]
    public class CraftingRecipes
    {

        //item
        public Item crafting_item1;
        public Item crafting_item2;
        //require
        public int req1=1;
        public int req2=1;
        //item sau khi craft
        public Item crafting_out;
        //so luong item sau khi craft
        public int craft_out=1;
    }
}
