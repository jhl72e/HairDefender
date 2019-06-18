using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    public GameObject inventoryPopup;

    public void Open()
    {
        inventoryPopup.SetActive(true);
    }

    public void Close()
    {
        inventoryPopup.SetActive(false);
    }
}
