using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject diari;
    public GameObject board;
    public GameObject dokumen;
    public GameObject piano;

    public bool isClose;

    void Start()
    {
        isClose = true;    
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "dairi")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(isClose == true)
                {
                    diari.SetActive(true);
                    isClose = false;
                }
                else
                {
                    diari.SetActive(false);
                    isClose = true;
                }
            }
        }

        if (other.gameObject.tag == "board")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isClose == true)
                {
                    board.SetActive(true);
                    isClose = false;
                }
                else
                {
                    board.SetActive(false);
                    isClose = true;
                }
            }
        }

        if (other.gameObject.tag == "dokumen")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isClose == true)
                {
                    dokumen.SetActive(true);
                    isClose = false;
                }
                else
                {
                    dokumen.SetActive(false);
                    isClose = true;
                }
            }
        }

        if (other.gameObject.tag == "piano")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isClose == true)
                {
                    piano.SetActive(true);
                    isClose = false;
                }
                else
                {
                    piano.SetActive(false);
                    isClose = true;
                }
            }
        }
    }
}
