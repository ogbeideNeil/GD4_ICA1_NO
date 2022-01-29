using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
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
    }

    public void Remove(Item item)
    {
        Evidence.Remove(item);
    }

    public void ListItems()
    {

        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in Evidence)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<string>();

        }
    }

}
