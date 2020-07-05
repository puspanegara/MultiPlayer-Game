using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BukaTutup : MonoBehaviour
{
    public GameObject panel;
    public bool isClose;

    // Start is called before the first frame update
    void Start()
    {
        isClose = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Diari")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isClose == true)
                {
                    panel.SetActive(true);
                    isClose = false;
                }
                else
                {
                    panel.SetActive(false);
                    isClose = true;
                }
            }
        }
    }
}
