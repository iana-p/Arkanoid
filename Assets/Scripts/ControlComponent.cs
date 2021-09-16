using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

namespace Arkanoid
{
    public class ControlComponent : MonoBehaviour
    {
        [SerializeField]
        private GameObject platform1;
        public static ControlComponent controlComponent;
        private static List<BlockComponent> blocks = new List<BlockComponent>();
        [SerializeField]
        private BallComponent _ball;
        public static int _lives = 3;
        [SerializeField]
        private GameObject _pauseMenu;
        private void Awake()
        {
            controlComponent = this;
            _lives = 3;
            UnpauseGame();
        }
        void Update()
        {
           if(_lives <= 0)
            {
                Debug.Log(":(");
                EditorApplication.isPaused = true;
            }
           if(blocks.Count == 0)
            {
                Debug.Log(":)");
                EditorApplication.isPaused = true;
            }
        }
        public static void AddBlock(BlockComponent block)
        {
           blocks.Add(block);
        }
        public static void RemoveBlock(BlockComponent block)
        {
           blocks.Remove(block);
        }
        public static void Damage()
        { 
            ControlComponent._lives--;
            controlComponent._ball.isInGame = false;
            controlComponent._ball.ReturnToStart();
        }
        public static void PauseGame()
        {
            Time.timeScale = 0;
            controlComponent._pauseMenu.SetActive(true);
        }
        public static void UnpauseGame()
        {
            Time.timeScale = 1;
            controlComponent._pauseMenu.SetActive(false);
        }
        public static void ResetLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        public static void ExitGame()
        {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        }
    }
}