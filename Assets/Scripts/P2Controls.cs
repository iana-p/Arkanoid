using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    public class P2Controls : BaseController
    {
        private Controls _controls;

        protected override void Start()
        {
            base.Start();
            _controls = new Controls();
            _controls.Player2.Enable();
        }
        private void FixedUpdate()
        {
            OnMoveVert(_controls.Player2.MovementLR.ReadValue<float>());
            OnMoveHor(_controls.Player2.MovementUD.ReadValue<float>());
        }
    }
}