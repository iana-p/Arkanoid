using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace Arkanoid
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        private Button _start;
        [SerializeField]
        private Button _settings;
        [SerializeField]
        private Button _quit;
        [SerializeField]
        private PanelOpener _menuPanel;
        [SerializeField]
        private PanelOpener _settingsPanel;
        private static MainMenu _mmenu;
        public static bool canChangeMenus = true;
        private void Start()
        {
            _mmenu = this;
            _quit.onClick.AddListener(ControlComponent.ExitGame);
            _start.onClick.AddListener(StartGame);
            _settings.onClick.AddListener(ToggleSettings);
            _menuPanel.TogglePanel();
        }
        public void StartGame()
        {
            SceneManager.LoadScene("GameScene");
        }
        public static void ToggleSettings()
        {
            _mmenu._menuPanel.TogglePanel();
            _mmenu._settingsPanel.TogglePanel();
        }
    }
}