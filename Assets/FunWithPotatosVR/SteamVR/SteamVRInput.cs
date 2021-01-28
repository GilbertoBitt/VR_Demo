using System;
using UnityEngine;
using UnityEngine.Serialization;
using Valve.VR;

namespace FunWithPotatosVR.SteamVR
{
    public class SteamVRInput : VRInputs
    {
        [SerializeField] private SteamVR_Action_Boolean triggerActionBoolean;
        [SerializeField] private SteamVR_Action_Single triggerActionSingle;
        [SerializeField] private SteamVR_Action_Boolean gripActionBoolean;
        [SerializeField] private SteamVR_Action_Single gripActionSingle;
        
        [SerializeField] private SteamVR_Action_Boolean buttonAActionBoolean;
        [SerializeField] private SteamVR_Action_Boolean buttonBActionBoolean;

        [SerializeField] private SteamVR_Action_Vector2 joystickActionAxis;
        

        private void Start()
        {
            triggerActionBoolean.AddOnStateDownListener(OnTriggerDown, SteamVR_Input_Sources.Any);
            triggerActionBoolean.AddOnStateUpListener(OnTriggerUp, SteamVR_Input_Sources.Any);
            triggerActionSingle.AddOnAxisListener(OnAxisTriggerUpdate, SteamVR_Input_Sources.Any);
            
            gripActionBoolean.AddOnStateDownListener(OnGripActionDown, SteamVR_Input_Sources.Any);
            gripActionBoolean.AddOnStateUpListener(OnGripActionUp, SteamVR_Input_Sources.Any);
            gripActionSingle.AddOnAxisListener(OnGripActionAxisUpdate, SteamVR_Input_Sources.Any);
            
            buttonAActionBoolean.AddOnStateDownListener(OnButtonAActionDown, SteamVR_Input_Sources.Any);
            buttonAActionBoolean.AddOnStateUpListener(OnButtonAActionUp, SteamVR_Input_Sources.Any);
            
            buttonBActionBoolean.AddOnStateDownListener(OnButtonBActionDown, SteamVR_Input_Sources.Any);
            buttonBActionBoolean.AddOnStateUpListener(OnButtonBActionUp, SteamVR_Input_Sources.Any);
            
            joystickActionAxis.AddOnAxisListener(OnAxisUpdate, SteamVR_Input_Sources.Any);
        }

        private void OnAxisUpdate(SteamVR_Action_Vector2 fromaction, SteamVR_Input_Sources fromsource, Vector2 axis, Vector2 delta)
        {
            JoytickAxisValue?.Invoke(axis);
        }

        private void OnButtonAActionDown(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            OnButtonAPressed?.Invoke();
        }
        
        private void OnButtonAActionUp(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            OnButtonAReleased?.Invoke();
        }
        
        private void OnButtonBActionDown(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            OnButtonBPressed?.Invoke();
        }
        
        private void OnButtonBActionUp(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            OnButtonBReleased.Invoke();
        }

        private void OnGripActionAxisUpdate(SteamVR_Action_Single fromaction, SteamVR_Input_Sources fromsource, float newaxis, float newdelta)
        {
            RightGripValue.Invoke(newaxis);
        }

        private void OnGripActionDown(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            OnRightGripPressed?.Invoke();
        }
        
        private void OnGripActionUp(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            OnRightGripReleased?.Invoke();
        }

        private void OnAxisTriggerUpdate(SteamVR_Action_Single fromaction, SteamVR_Input_Sources fromsource, float newaxis, float newdelta)
        {
            RightTriggerValue?.Invoke(newaxis);
        }

        private void OnTriggerUp(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            onRightTriggerReleased?.Invoke();
        }

        private void OnTriggerDown(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource)
        {
            onRightTriggerPressed?.Invoke();
        }
    }
}