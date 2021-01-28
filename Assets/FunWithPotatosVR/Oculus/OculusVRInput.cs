using System;
using UnityEngine;

namespace FunWithPotatosVR.Oculus
{
    public class OculusVRInput : VRInputs
    {
        public void Update()
        {
            RightTriggerValue?.Invoke(OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.All));
            if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) onRightTriggerPressed?.Invoke();
            if(OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)) onRightTriggerPressed?.Invoke();
            
            RightGripValue?.Invoke(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.All));
            if(OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger)) OnRightGripPressed?.Invoke();
            if(OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger)) OnRightGripReleased?.Invoke();
            
            if(OVRInput.GetDown(OVRInput.Button.One)) OnButtonAPressed?.Invoke();
            if(OVRInput.GetUp(OVRInput.Button.One)) OnButtonAReleased?.Invoke();
            
            if(OVRInput.GetDown(OVRInput.Button.Two)) OnButtonBPressed?.Invoke();
            if(OVRInput.GetUp(OVRInput.Button.Two)) OnButtonBReleased?.Invoke();
            
            JoytickAxisValue?.Invoke(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));
        }
    }
}