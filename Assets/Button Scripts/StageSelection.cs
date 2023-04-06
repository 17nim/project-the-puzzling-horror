using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelection : MonoBehaviour
{
    public void LoadScene1() {
        SceneManager.LoadScene("map 1");
    }

    public void LoadScene2() {
        SceneManager.LoadScene("map 2");
    }

    public void LoadScene3() {
        SceneManager.LoadScene("map 3");
    }
}
