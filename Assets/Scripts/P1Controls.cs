using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    public class P1Controls : BaseController
    {
        private Controls _controls;
        [SerializeField]
        private BallComponent _ball;
        [Range(1f, 4f)]
        public static float _ballSpeedBoost;
        protected override void Start()
        {
            base.Start();
            _controls = new Controls();
            _controls.Player1.Enable(); 
            _controls.Player1.LaunchBall.performed += _ => OnBallLaunch();
            _controls.Player1.PauseGame.performed += _ => OnGamePaused();
        }
        private void FixedUpdate()
        {
            OnMoveVert(_controls.Player1.MovementLR.ReadValue<float>());
            OnMoveHor(_controls.Player1.MovementUD.ReadValue<float>());
            //if (!_ball.isInGame)
            //{
               
            //}
        }
        private void OnBallLaunch()
        {
            if (!_ball.isInGame)
            {
                _ball.isInGame = true;
            }
        }
        private void OnGamePaused()
        {
            ControlComponent.PauseGame();
        }
    }
}