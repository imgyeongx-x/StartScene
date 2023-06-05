using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.Audio;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public AudioMixer MyMixer;
    public Slider audioSlider;
    // private AudioSource audioSource;
    // private GameObject[] musics;

    // private void Awake(){
    //     musics = GameObject.FindGameObjectsWithTag("Music");
    //     if(musics.Length>=2){
    //         Destroy(this.gameObject);
    //     }

    //     DontDestroyOnLoad(transform.gameObject);
    //     audioSource = GetComponent<AudioSource>();
    // }

    public void AudioControl(){
        float sound = audioSlider.value;

        if(sound<=-40f) MyMixer.SetFloat("Music", -80f);
        else MyMixer.SetFloat("Music", sound);
    }

    public void ToggleAudioVolume(){
        AudioListener.volume = AudioListener.volume == 0?1:0;
    }
}
