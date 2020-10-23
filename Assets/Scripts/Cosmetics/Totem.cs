﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totem : MonoBehaviour{
    private AudioSource source;

    // Start is called before the first frame update
    void Start() {
        source = GetComponent<AudioSource>();
    }

    private void Update() {
        float volume = PlayerPrefs.GetFloat("AmbientVolume");
        if (source.volume != volume) {
            source.volume = volume;
        }
    }
}
