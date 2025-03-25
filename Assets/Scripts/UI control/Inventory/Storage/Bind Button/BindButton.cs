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


        ItemBinding.instance.BindItem(soNguyen,StorageController.instance.choosingButton, PlayerInvent.instance.item[StorageController.instance.choosingButton].id);
        StorageController.instance.choosingButton = -1;
    }
    
}
