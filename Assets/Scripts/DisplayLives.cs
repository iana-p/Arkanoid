using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Arkanoid
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class DisplayLives : MonoBehaviour
    {
        private TextMeshProUGUI _text;
        private void Start()
        {
            _text = gameObject.GetComponent<TextMeshProUGUI>();
            //_text.SetText(ControlComponent._lives.ToString());
        }
        void Update()
        {
            _text.SetText(ControlComponent._lives.ToString());
        }
    }
}