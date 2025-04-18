using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KitchenUI : MonoBehaviour
{

    [SerializeField] private List<CookingRecipes> cookingRecipes;

    [SerializeField] private GameObject cookUI;
    //left panel
    public List<Button> cookItem;
    //right panel
    //text
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI congthuc_text;
    [SerializeField] private TextMeshProUGUI plus_mark;
    //image
    [SerializeField] private GameObject cookButton;
    [SerializeField] private Image item1;
    [SerializeField] private Image item2;

    public int choosing_Item = -1;
    private void Awake()
    {
        for (int i = 0; i < cookItem.Count; i++)
        {
            int index = i;
            cookItem[i].GetComponent<Button>().onClick.AddListener(() => ChangeChossingItem(index));
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (choosing_Item != -1)
        {
            itemName.text = cookingRecipes[choosing_Item].cooking_out.itemName;
            item1.sprite = cookingRecipes[choosing_Item].cooking_item1.itemImage;
            item1.enabled = true;
            item2.sprite = cookingRecipes[choosing_Item].cooking_item2.itemImage;
            item2.enabled = true;
            plus_mark.text = "+";
            congthuc_text.text = "Công thức";
            cookButton.SetActive(true);
        }
        else
        {
            itemName.text = "";
            item1.enabled = false;
            item2.enabled = false;
            plus_mark.text = "";
            congthuc_text.text = "";
            cookButton.SetActive(false);
        }
    }
    public void CloseCookUI()
    {
        cookUI.SetActive(false);
    }
    private void ChangeChossingItem(int index)
    {   
        print(index);
        choosing_Item = index;
    }
    public void Cook()
    {
        if (PlayerInvent.instance.CheckItem(cookingRecipes[choosing_Item].cooking_item1.itemName, cookingRecipes[choosing_Item].item1_quantity) && PlayerInvent.instance.CheckItem(cookingRecipes[choosing_Item].cooking_item2.itemName, cookingRecipes[choosing_Item].item2_quantity))
        {
            PlayerInvent.instance.UseItem(cookingRecipes[choosing_Item].cooking_item1, cookingRecipes[choosing_Item].item1_quantity);
            PlayerInvent.instance.UseItem(cookingRecipes[choosing_Item].cooking_item2, cookingRecipes[choosing_Item].item1_quantity);
            PlayerInvent.instance.AddItem(cookingRecipes[choosing_Item].cooking_out, cookingRecipes[choosing_Item].out_quantity);
        }
        else
        {
            MesAndNoti.instance.SetNotification("Bạn không có đủ nguyên liệu");
        }
    }
}
[System.Serializable]
public struct CookingRecipes
{
    public Item cooking_item1;
    public int item1_quantity;
    public Item cooking_item2;
    public int item2_quantity;
    public Item cooking_out;
    public int out_quantity;
}
