using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneItem : MonoBehaviour
{
    public GameObject keyGone;
    public GameObject slot;

    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
            slot.GetComponent<BoxCollider>().enabled = true;

        if (Input.GetKeyDown(KeyCode.E))
            keyGone.SetActive(false);

    }
}
