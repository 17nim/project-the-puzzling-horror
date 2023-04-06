using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    public AudioSource OpenDoor;
    public void playThisSoundEffect()
    {
        OpenDoor.Play();
        
    }
}
