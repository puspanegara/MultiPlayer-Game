using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScene : MonoBehaviour
{
    public int noScene;
    public bool idCard;

    void OnTriggerStay()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ChangeScene();
        }
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(noScene);
    }
}
