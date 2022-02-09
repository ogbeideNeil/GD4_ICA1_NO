using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*https://www.youtube.com/watch?v=YLhj7SfaxSE
 * line 9-47
*/

public class inventoryUI : MonoBehaviour
{

    public Transform ItemUIMenu;
    inventorySlot[] slots;

    InventoryManager inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = InventoryManager.Instance;
        inventory.onItemChangedCallback += updateUI;

        slots = ItemUIMenu.GetComponentsInChildren<inventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateUI()
    {
        for (int i =0; i < slots.Length; i++)
        {
            if(i< inventory.Evidence.Count)
            {
                slots[i].AddItem(inventory.Evidence[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

}
