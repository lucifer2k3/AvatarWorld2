using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "acttive button control", menuName = "active button control")]
public class ItemBinding : MonoBehaviour
{
    public static ItemBinding instance;
    private void Awake()
    {
        instance = this;
    }
    public int usingItem = 0;
    public int[] posInInvent = {-1, -1, -1, -1, -1, -1 };
    public int[] itemID= new int[6];
    public void BindItem(int pos,int inventpos,int id)
    {
        posInInvent[pos] = inventpos;
        itemID[pos] = id;
    }
    private void FixedUpdate()
    {
        for (int i=0;i<6;i++)
        {
            if (posInInvent[i] != -1)
            {
                if (PlayerInvent.instance.item[posInInvent[i]].amount == 0)
                {
                    posInInvent[i] = -1;
                }
            }
        }
    }
}
