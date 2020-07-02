using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPick : MonoBehaviour
{
    public GameObject itemButton;
    private Inventory inventory;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("Berhasil");
                        inventory.isFull[i] = true;
                        Instantiate(itemButton, inventory.slots[i].transform, false);
                        Destroy(gameObject);
                        break;
                    }
                }
            }
        }
    }
}
