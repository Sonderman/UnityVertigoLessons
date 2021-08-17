using UnityEngine;

namespace TopDownShooter.Camera
{
    [CreateAssetMenu(menuName = "TopDownShooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpspeed=1;
        public float RotationLerpSpeed { get { return _rotationLerpspeed; } }

        [Header("Position")]
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset { get { return _positionOffset; } }
        [SerializeField] private float _positionLerp=1;
        public float PositionLerp { get { return _positionLerp; } }
    }
    
}
