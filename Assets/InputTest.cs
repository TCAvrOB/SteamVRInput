using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InputTest : MonoBehaviour {

    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean TouchPad;
    public SteamVR_Action_Boolean Trigger;

    void Update()
    {
        if (TouchPad.GetStateDown(HandType))
        {
            Debug.Log("TouchPad Down");
        }

        if (TouchPad.GetStateUp(HandType))
        {
            Debug.Log("TouchPad Up");
        }

        if (Trigger.GetStateDown(HandType))
        {
            Debug.Log("Trigger Down");
        }

        if (Trigger.GetStateUp(HandType))
        {
            Debug.Log("Trigger Up");
        }
    }
}
