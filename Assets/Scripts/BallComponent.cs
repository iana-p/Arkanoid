using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    public class BallComponent : MonoBehaviour
    {
        [SerializeField, Range(1f, 5f)]
        public float ballSpeed;
        public bool isInGame;
        private Vector3 _startPos;
        private Quaternion _startRot;
        [SerializeField]
        P1Controls platform1;
        private void Start()
        {
            _startPos = transform.position;
            _startRot = transform.rotation;
        }
        private void FixedUpdate()
        {
            if(isInGame)
            { 
                StartCoroutine(MoveBall());
            }
            if(!isInGame)
            {
                transform.position = platform1.transform.position + new Vector3(0, -0.3f, 0);
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            transform.forward = Vector3.Reflect(transform.forward, collision.GetContact(0).normal);
        }
        IEnumerator MoveBall()
        {
            transform.position += transform.forward * ballSpeed * Time.deltaTime;
            yield return null;
        }
        public void ReturnToStart()
        {
            transform.rotation = _startRot;
            transform.position = _startPos;    
        }
    }
}