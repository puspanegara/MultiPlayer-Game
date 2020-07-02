using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    public Component doorCollider;
    public GameObject keyGone;

    void OnTriggerStay()
    {
        if(Input.GetKeyDown(KeyCode.E))
            doorCollider.GetComponent<BoxCollider>().enabled = true;

        if(Input.GetKeyDown(KeyCode.E))
            keyGone.SetActive(false);
        
    }
}
