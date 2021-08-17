using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDownShooter/UserInput/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal, Vertical;
    }
}
