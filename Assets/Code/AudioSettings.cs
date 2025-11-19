using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;

    void Start()
    {
        // Load saved volume (default 1.0 if no value saved yet)
        float savedVolume = PlayerPrefs.GetFloat("MusicVolume", 1f);
        musicSource.volume = savedVolume;
        volumeSlider.value = savedVolume;

        // Add listener for slider
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        musicSource.volume = volume;

        // Save the value
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }
}
