using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InputTest : MonoBehaviour {

    public SteamVR_Input_Sources HandType;
    public SteamVR_Action_Boolean GrabAction;
    public SteamVR_Action_Vector3 AxisInput;

    [SerializeField]
    Vector3 axis;

    void Update()
    {
        if (GrabAction.GetStateDown(HandType))
        {
            Debug.Log("GetStateDown");
        }

        if (GrabAction.GetStateUp(HandType))
        {
            Debug.Log("GetLastStateUp");
        }

        axis = AxisInput.GetAxis(HandType);
    }
}
