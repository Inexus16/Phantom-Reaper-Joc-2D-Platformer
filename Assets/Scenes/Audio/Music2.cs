using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music2 : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject ObjectMusic;
    public AudioSource AudioSource;
    private void Start()
    {
        ObjectMusic = GameObject.FindWithTag("Music");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();

        if (!PlayerPrefs.HasKey("volume"))
        {
            PlayerPrefs.SetFloat("volume", 0.2f);
            Load();
        }
        //this
        volumeSlider.value = AudioSource.volume;

        Load();
    }

    public void ChangeVolume()
    {
        //this
        AudioSource.volume = volumeSlider.value;

        //AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        //this delete and un-the_under
        AudioSource.volume = PlayerPrefs.GetFloat("volume");
        //volumeSlider.value = PlayerPrefs.GetFloat("volume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.Save();
    }
}
