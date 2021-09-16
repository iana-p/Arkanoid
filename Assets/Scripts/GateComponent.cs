using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    public class GateComponent : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            ControlComponent.Damage();
        }
    }
}