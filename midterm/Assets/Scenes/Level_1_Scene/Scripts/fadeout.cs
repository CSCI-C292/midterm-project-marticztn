﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeout : MonoBehaviour
{
    private const float fadeOutDuration = 1.5f;
    public Image blackFade;

    // Start is called before the first frame update
    void Start()
    {
        blackFade.canvasRenderer.SetAlpha(1.0f);
        fadeOut();
    }

    // Update is called once per frame
    void fadeOut()
    {
        blackFade.CrossFadeAlpha(0, fadeOutDuration, false);
    }
}
