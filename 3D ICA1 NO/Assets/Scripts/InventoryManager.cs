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
        Evidence.Add(item);
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
            //GameObject obj = Instantiate(InventoryItem, ItemContent);
            //var itemName = obj.transform.Find("ItemName").GetComponent<string>();
            //var itemName = obj.name;
            //var itemIcon = obj.GetComponent<>

            //itemName = item.ItemName;
            
            //var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            //itemIcon.sprite = item.icon;
            //itemName.m

        }

    }
    

}
