﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileInfo : MonoBehaviour {

    public string profileName;
    public string profileEmail;
    public int saveSlot;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}