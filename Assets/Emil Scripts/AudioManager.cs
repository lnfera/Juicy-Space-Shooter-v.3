using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    //Ger en reference till vilken Audio Mixer vi använder
    public  AudioMixer audioMixer;
    public Slider masterVolume;
    public Slider musicVolume;
    public Slider sfxVolume;

    //Kontrollerar volymen i gruppen "Master"
    public  void SetMasterVolume(Slider volume) { audioMixer.SetFloat("Master", masterVolume.value); }
    //Kontrollerar volymen i gruppen "Music"
    public void SetMusicVolume(Slider volume) { audioMixer.SetFloat("Music", musicVolume.value);
    }
    //Kontrollerar volymen i gruppen "SFX"
    public  void SetSFXVolume(Slider volume) { audioMixer.SetFloat("SFX", sfxVolume.value); }

    private void Update()
    {
        
    }
}
