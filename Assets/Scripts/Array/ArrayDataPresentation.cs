using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Item
{
    public int ItemID;
    public string ItemName;
    public string Description;
}
public class ArrayDataPresentation : MonoBehaviour
{
   public Item[] playerItems;

    private void Start()
    {
        foreach (var item in playerItems)
        {
            Debug.Log(item.ItemID);
        }

        Debug.Log(playerItems[2].ItemID);
        Debug.Log(playerItems[2].ItemName);
    }
}
 