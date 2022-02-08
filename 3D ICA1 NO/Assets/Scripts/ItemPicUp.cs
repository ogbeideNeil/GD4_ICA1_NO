using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicUp : MonoBehaviour
{
    // Start is called before the first frame update

    public Item[] allItems;




    public void pickUpKnife()
    {
        //if (Input.GetMouseButtonDown(1))
        //{
            InventoryManager.Instance.Add(allItems[0]);
        //}


    }

    public void pickUpScrolls()
    {
        InventoryManager.Instance.Add(allItems[1]);
        InventoryManager.Instance.Add(allItems[2]);
    }
    public void pickUpBook()
    {
        InventoryManager.Instance.Add(allItems[3]);
    }

    public void pickUpWine()
    {
        InventoryManager.Instance.Add(allItems[4]);
    }

    private void OnMouseDown()
    {
       // pickUp();
    }

}
