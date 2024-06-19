using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundSFX2 : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject ObjectMusic;
    public AudioSource AudioSource;
    private void Start()
    {
        ObjectMusic = GameObject.FindWithTag("SFX");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();

        if (!PlayerPrefs.HasKey("volumeSFX"))
        {
            PlayerPrefs.SetFloat("volumeSFX", 1f);//also does not matter
            Load();
        }
        volumeSlider.value = AudioSource.volume;
        Load();
    }

    public void ChangeVolume()
    {
        AudioSource.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        AudioSource.volume = PlayerPrefs.GetFloat("volumeSFX");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volumeSFX", volumeSlider.value);
        PlayerPrefs.Save();
    }
}
