using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    public GameObject inventoryUI;
    public string buttonSelect;
    void Update()
    {
        OpenCloseInven();
    }
    public void OpenCloseInven()
    {
        if(Input.GetButtonDown("buttonSelect"))
        {

        }
    }
}
