using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomClass : MonoBehaviour
{
    private ItemClass survivalItems;
    private ItemClass enhancementItem;


    //DECLARATION WHEN ITEM CLASS ACCESS USING FUNCTION
    private ItemClass gatheredItems;

    private void Start()
    {
        //survivalItems = new ItemClass();
        //survivalItems.ItemName = "Red Potion";
        //survivalItems.ItemPrice = 35.4f;
        //survivalItems.ItemCount = 10;


        //enhancementItem = new ItemClass();
        //enhancementItem.ItemName = "Adrenaline Potion";
        //enhancementItem.ItemPrice = 95.4f;
        //enhancementItem.ItemCount = 12;


        //USING CONTRUCTOR TO FEED THE PARAMETER
        survivalItems = new ItemClass("Red Potion", 35.4f, 10);
        enhancementItem = new ItemClass("Adrenaline Potion",95.4f,12);


        //USING FUNCTION
        gatheredItems = CreateItems("Yellow Potion", 35.2f, 12);

        
    }


    //USING FUNCTION TO ACCESS THE CLASS
    private ItemClass CreateItems(string name, float price, int count)
    {
        ItemClass items = new ItemClass(name, price, count);
        //var items = new ItemClass(name, price, count);     //ALTERNATIVE WAY OF WRITING IT

        return items;
    }

}
