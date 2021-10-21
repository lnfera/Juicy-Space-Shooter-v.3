using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    //Ger en reference till vilken Audio Mixer vi använder
    public static AudioMixer AudioMixer;
    //Kontrollerar volymen i gruppen "Master"
    public static void SetMasterVolume(Slider volume) { AudioMixer.SetFloat("Master", volume.value); }
    //Kontrollerar volymen i gruppen "Music"
    public static void SetMusicVolume(Slider volume) { AudioMixer.SetFloat("Music", volume.value); }
    //Kontrollerar volymen i gruppen "SFX"
    public static void SetSFXVolume(Slider volume) { AudioMixer.SetFloat("SFX", volume.value); }
}
