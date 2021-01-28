using System;
using UnityEngine;
using UnityEngine.Events;

namespace FunWithPotatosVR
{
    public class VRInputs : MonoBehaviour
    {
        public Action onRightTriggerPressed;
        public Action onRightTriggerReleased;
        public Action<float> RightTriggerValue;

        public Action OnRightGripPressed;
        public Action OnRightGripReleased;
        public Action<float> RightGripValue;

        public Action OnButtonAPressed;
        public Action OnButtonAReleased;
        
        public Action OnButtonBPressed;
        public Action OnButtonBReleased;
        
        public Action<Vector2> JoytickAxisValue;

    }
}
