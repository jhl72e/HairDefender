using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Setting : MonoBehaviour
{
    public GameObject popup;

    public void Open()
    {
        popup.SetActive(true);
    }

    public void Close()
    {
        popup.SetActive(false);
    }
}
