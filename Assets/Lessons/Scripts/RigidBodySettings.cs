using UnityEngine;

namespace Lesson
{
    [CreateAssetMenu(menuName = "Lessons/Lesson1/Rigidbody Settings")]
    public class RigidBodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpforce;
        public Vector3 JumpForce { get { return _jumpforce; } }
    }
}
