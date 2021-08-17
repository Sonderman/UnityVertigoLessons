using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "TopDownShooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeed=5, VerticalSpeed=5;
    }
}