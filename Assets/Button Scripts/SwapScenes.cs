using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SwapScenes : MonoBehaviour
{
    string[] mapsArray = {"map 1", "map 2", "map 3"};

    /*void Start() {
        BGmusic.instance.GetComponent<AudioSource>().Play();
    }*/
    void Update()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        if (Array.IndexOf(mapsArray, currentSceneName) >= 0)
        {
            BGmusic.instance.GetComponent<AudioSource>().Pause();
        } else
        {
            BGmusic.instance.GetComponent<AudioSource>().UnPause();
        }
    }
}