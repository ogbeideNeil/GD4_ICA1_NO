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


    public void pickUpBody()
    {
        InventoryManager.Instance.Add(allItems[5]);
    }

    public void pickUpMarks()
    {
        InventoryManager.Instance.Add(allItems[8]);
    }

    public void pickUpTak()
    {
        InventoryManager.Instance.Add(allItems[6]);
    }

    public void pickUpGar()
    {
        InventoryManager.Instance.Add(allItems[7]);
    }
    private void OnMouseDown()
    {
       // pickUp();
    }

}
