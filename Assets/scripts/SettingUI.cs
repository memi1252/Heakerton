using System;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{
    [SerializeField] public Slider bgmSlider;
    [SerializeField] public Slider sfxSlider;
    [SerializeField] private Button closeButton;

    private void Awake()
    {
        gameObject.SetActive(false);
        closeButton.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
