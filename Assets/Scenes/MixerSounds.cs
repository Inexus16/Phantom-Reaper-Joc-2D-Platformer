using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixerSounds : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider volumeSlider;

    const string MixerMusic = "MusicVolume";
    const string MixerSFX = "SFXVolume";

    private void Start()
    {
        //volumeSlider.value = 0;
    }

    private void Awake()
    {
        volumeSlider.onValueChanged.AddListener(SetMusicVolume);
    }

    private void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat(MixerMusic, Mathf.Log10(volume) * 20);
        audioMixer.SetFloat(MixerSFX, Mathf.Log10(volume) * 20);
    }
}
