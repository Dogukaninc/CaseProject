﻿using Sirenix.OdinInspector;
using UnityEngine;

namespace CaseDemo.Scripts.SO_Classes
{
    [CreateAssetMenu(fileName = "so_fortune_wheel_config", menuName = "Scriptable Objects/so_fortune_wheel_config", order = 0)]
    public class FortuneWheelConfigSo : ScriptableObject
    {
        [field: SerializeField] public float RotationDuration { get; private set; }
        [field: SerializeField] public float SlotYPosOffset { get; private set; }
        [field: SerializeField] public int DesiredSlotCount { get; private set; }
        [field: SerializeField] public int InitialRotationCount { get; private set; }
        
        

    }
}