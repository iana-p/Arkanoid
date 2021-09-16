using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Arkanoid
{
    public class SettingsMenu : MonoBehaviour
    {
        [SerializeField]
        private Button _back;
        [SerializeField]
        private Toggle _mute;
        [SerializeField]
        private Slider _volume;
        [SerializeField]
        private Toggle[] _difficulty;
        private void Start()
        {
            RecallSettings();
            _back.onClick.AddListener(MainMenu.ToggleSettings);
            _back.onClick.AddListener(SaveSettings);
        }
        private void SaveSettings()
        {
            for (int i = 0; i < 3; i++)
            {
                if (_difficulty[i].isOn)
                {
                    PlayerPrefs.SetInt("Difficulty", i);
                }
            }
            if (_mute.isOn)
            {
                PlayerPrefs.SetInt("Mute", 1);
            }
            else
            {
                PlayerPrefs.SetInt("Mute", 0);
            }
            PlayerPrefs.SetFloat("Volume", _volume.value);
        }
        private void RecallSettings()
        {
            int diff = PlayerPrefs.GetInt("Difficulty");
            _difficulty[diff].isOn = true;
            if(PlayerPrefs.GetInt("Mute") == 1)
            {
                _mute.isOn = true;
            }
            else
            {
                _mute.isOn = false;
            }
            _volume.value = PlayerPrefs.GetFloat("Volume");
        }
        
    }
}