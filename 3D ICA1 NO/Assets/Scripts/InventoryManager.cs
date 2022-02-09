using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;


    public List<Item> Evidence = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
     

            if (!Evidence.Contains(item))
            {
                Evidence.Add(item);
            }



        
        if(onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
        
    }

    public void Remove(Item item)
    {
        Evidence.Remove(item);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }


    
    public void ListItems()
    {

        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }


        foreach (var item in Evidence)
        {

        }

    }
    

}
