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
    [Header("*Item name text,cong thuc text, dau cong text vut vao day")]
    [SerializeField] public List<TextMeshProUGUI> text;
    //image 
    [Header("*Anh item")]
    [SerializeField] private Image crafting_image1;
    [SerializeField] private Image crafting_image2;

    //craft recipes
    [Header("*Cong thuc che tao")]
    [SerializeField] private List<CraftingRecipes> craftingRecipes;
    void Awake()
    {
        Instance= this;
    }

    
    void FixedUpdate()
    {
        if (choosing_Item != -1)
        {
            for (int i = 0; i < text.Count; i++)
            {
                text[0].text = craftingRecipes[choosing_Item].crafting_out.itemName;
                text[1].text = "Công thức";
                text[2].text = "+";
            }
            crafting_image1.enabled = true;
            crafting_image2.enabled = true;
            
            crafting_image1.sprite = craftingRecipes[choosing_Item].crafting_item1.itemImage;
            crafting_image2.sprite = craftingRecipes[choosing_Item].crafting_item2.itemImage;
        }
        else
        {
            for (int i = 0; i < text.Count; i++)
            {
                text[i].text = "";
            }
            crafting_image1.sprite = null;
            crafting_image2.sprite = null;
            crafting_image1.enabled= false;
            crafting_image2.enabled= false;
        }
    }
    public void CraftItem()
    {
        if (choosing_Item != -1)
        {
            PlayerInvent.instance.UseItem(craftingRecipes[choosing_Item].crafting_item1, craftingRecipes[choosing_Item].req1);
            PlayerInvent.instance.UseItem(craftingRecipes[choosing_Item].crafting_item2, craftingRecipes[choosing_Item].req2);
            PlayerInvent.instance.AddItem(craftingRecipes[choosing_Item].crafting_out, 1);
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
