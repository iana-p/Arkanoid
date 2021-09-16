using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Arkanoid
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField]
        private Button _resume;
        [SerializeField]
        private Button _reset;
        [SerializeField]
        private Button _quit;
        void Start()
        {
            _resume.onClick.AddListener(ControlComponent.UnpauseGame);
            _reset.onClick.AddListener(ControlComponent.ResetLevel);
            _quit.onClick.AddListener(ControlComponent.ExitGame);
        }
    }
}