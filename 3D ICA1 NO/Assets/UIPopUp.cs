using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class UIPopUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    //public Transform ItemUIThing;
    public Canvas canvas;

    //public string Text;

    private bool mouse_over = false;
    public inventorySlot inventorySlot;
    public InventoryManager inventory;

    public TMP_Text tMP_Text;


    void Update()
    {


        if (mouse_over == true)
        {
            //inventorySlot = inventorySlot.Instance;
            //Debug.Log("Mouse Over");
        }
    }

    private void Start()
    {
        
        inventory = InventoryManager.Instance;



    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        

        if (inventorySlot.icon.sprite != null)
        {

            mouse_over = true;
            canvas.enabled = true;


            tMP_Text.text = inventorySlot.item.description;

        }

        if(inventory.Evidence.Count != 0)
        {
            //Debug.Log("Empty");
        }




    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        canvas.enabled = false;
        //Debug.Log("Mouse exit");
    }

}
