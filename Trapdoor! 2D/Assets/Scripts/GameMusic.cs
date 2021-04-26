﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class allows background music to play across scenes.
public class GameMusic : MonoBehaviour
{

    private static GameMusic instance = null;
    public static GameMusic Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
            
    }
}
