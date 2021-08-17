using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        private void Update()
        {
           _inputData.Horizontal = Input.GetAxis("Horizontal");
            _inputData.Vertical = Input.GetAxis("Vertical");
        }
    }
}
