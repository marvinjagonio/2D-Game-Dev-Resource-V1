using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class ItemClass
{
    public string ItemName;
    public float ItemPrice;
    public int ItemCount;


    //*USING CONSTRUCTOR*

    public ItemClass(string ItemName, float ItemPrice, int ItemCount)
    {
        this.ItemName = ItemName;
        this.ItemPrice = ItemPrice;
        this.ItemCount = ItemCount;
    }
    
}
