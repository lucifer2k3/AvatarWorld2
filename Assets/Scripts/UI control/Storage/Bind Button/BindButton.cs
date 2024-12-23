using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BindButton : MonoBehaviour
{
    public void Bind()
    {   
        string chuoi = this.transform.name;
        int viTriDauNgoacMo = chuoi.IndexOf('(');
        string so = chuoi.Substring(viTriDauNgoacMo + 1, chuoi.Length - viTriDauNgoacMo - 2);
        int soNguyen = int.Parse(so);
        ItemBinding.itemBindingForButton[soNguyen] = StorageController.instance.choosingButton;
        //print(ItemBinding.itemBindingForButton[soNguyen]);
        StorageController.instance.choosingButton = -1;
    }
    
}
