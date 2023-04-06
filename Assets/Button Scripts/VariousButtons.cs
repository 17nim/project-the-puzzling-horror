using UnityEngine;
using UnityEngine.SceneManagement;

public class VariousButtons : MonoBehaviour
{
    public void BackToMain() {
        SceneManager.LoadScene("StartMenu");
    }
}
