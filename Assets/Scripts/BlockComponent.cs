using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    public class BlockComponent : MonoBehaviour
    {
        void Start()
        {
            transform.rotation = Quaternion.Euler(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            ControlComponent.AddBlock(this);
        }
        void Update()
        {

        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.GetComponent<BallComponent>())
            {
                ControlComponent.RemoveBlock(this);
                Destroy(this.gameObject);
            }
        }
    }
}