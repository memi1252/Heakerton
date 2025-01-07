using System;
using Unity.VisualScripting;
using UnityEngine;

public class soundManger : MonoBehaviour
{ 
    public AudioSource bgm;
    public AudioSource sfx;
    
    [SerializeField] private AudioClip[] bgmClips;
    [SerializeField] private AudioClip[] sfxClips;
    
    [SerializeField] private SettingUI settingUI;
    

    private void Awake()
    {
        bgm = transform.AddComponent<AudioSource>();
        sfx = transform.AddComponent<AudioSource>();
        bgm.clip = bgmClips[0];
        bgm.loop = true;
        bgm.Play();
    }

    private void Update()
    {
        bgm.volume = settingUI.bgmSlider.value;
        sfx.volume = settingUI.sfxSlider.value;
    }
}
