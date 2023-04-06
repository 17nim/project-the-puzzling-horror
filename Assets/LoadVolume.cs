using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LoadVolume : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;

    void Start()
    {
        audioMixer.SetFloat("masterVolume", PlayerPrefs.GetFloat("masterVolume"));
    }
}
