﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashCamera: MonoBehaviour
{

    public Image splashimg;
    public string Levelke;

    // Use this for initialization
    IEnumerator Start()
    {
        splashimg.canvasRenderer.SetAlpha(0f);

        Muncul();
        yield return new WaitForSeconds(2.5f);
        Redup();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(Levelke);

    }

    void Muncul()
    {
        splashimg.CrossFadeAlpha(1f, 2.5f, false);
    }

    void Redup()
    {
        splashimg.CrossFadeAlpha(0f, 2.5f, false);
    }
}