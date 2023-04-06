using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider volumeSlider;

    void Update() 
    {
        LoadValues();
    }

    public void SetVolume(float volume)
    {
        PlayerPrefs.SetFloat("masterVolume", volume);
        audioMixer.SetFloat("masterVolume", volume);
    }
    
    void LoadValues() 
    {
        float volumeValue = PlayerPrefs.GetFloat("masterVolume");
        volumeSlider.value = volumeValue;
    }

    void ShowCredits() 
    {
        SceneManager.LoadScene("Credits");
    }

    public void ResetVolume() 
    {
        PlayerPrefs.SetFloat("masterVolume", 0);
    }
}
