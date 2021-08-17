using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerMovementSettings playerMovementSettings;
        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position + _rigidbody.transform.forward * _inputData.Vertical*playerMovementSettings.VerticalSpeed);
            _rigidbody.MovePosition(_rigidbody.position + _rigidbody.transform.right * _inputData.Horizontal*playerMovementSettings.HorizontalSpeed);
        }
    }
}
