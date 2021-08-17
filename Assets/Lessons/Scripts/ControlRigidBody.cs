using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson
{
    public class ControlRigidBody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidBodySettings _settings;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }
    }

}