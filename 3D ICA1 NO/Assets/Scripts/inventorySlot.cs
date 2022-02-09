using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*https://www.youtube.com/watch?v=YLhj7SfaxSE
 * line 9-37
*/
public class inventorySlot : MonoBehaviour
{

    public static inventorySlot Instance;

    public Image icon;
    public Item item;

    public void Awake()
    {
        Instance = this;
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }

}
