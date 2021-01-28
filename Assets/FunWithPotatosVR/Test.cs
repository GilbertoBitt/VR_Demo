using System;
using UnityEngine;

namespace FunWithPotatosVR
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private VRInputs vrInputs;

        private void Start()
        {
            vrInputs.JoytickAxisValue += axis =>
            {
                Debug.Log($"Axis Value Changed to {axis.ToString()}");
            };

            vrInputs.onRightTriggerPressed += () =>
            {
                Debug.Log($"Right Trigger Pressed");
            };
            
            vrInputs.OnRightGripPressed += () =>
            {
                Debug.Log($"Right Grip Pressed");
            };
            
            vrInputs.OnButtonAPressed += () =>
            {
                Debug.Log($"Button A Pressed");
            };
            
            vrInputs.OnButtonBPressed += () =>
            {
                Debug.Log($"Button B Pressed");
            };

            vrInputs.RightTriggerValue += value =>
            {
                Debug.Log($"Right Trigger Value {value.ToString()}");
            };
            
            vrInputs.RightGripValue += value =>
            {
                Debug.Log($"Right Grip Value {value.ToString()}");
            };
        }
    }
}