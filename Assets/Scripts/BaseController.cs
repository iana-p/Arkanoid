using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class BaseController : MonoBehaviour
    {
        protected Rigidbody _rigidBody;
        [SerializeField, Range(2f, 25f), Tooltip("Скорость движения платформы.")]
        private float _moveSpeed = 2f;

        protected virtual void Start()
        {
            _rigidBody = GetComponent<Rigidbody>();
        }

        protected void OnMoveVert(float axis)
        {
            var vector = transform.right * axis * _moveSpeed * Time.fixedDeltaTime;
            _rigidBody.velocity += vector;
        }
        protected void OnMoveHor(float axis)
        {
            var vector = transform.forward * axis * _moveSpeed * Time.fixedDeltaTime;
            _rigidBody.velocity += vector;
        }

    }
}