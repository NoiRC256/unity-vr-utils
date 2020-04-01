using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

// https://www.youtube.com/watch?v=kXD0hO0I8DM
// Sauce: VR with Andrew

public class InputDebug_Index : MonoBehaviour
{
    public SteamVR_Action_Vector2 ThumbstickAction = null;
    public SteamVR_Action_Vector2 TrackpadAction = null;

    public SteamVR_Action_Single SqueezeAction = null;
    public SteamVR_Action_Boolean GripAction = null;
    public SteamVR_Action_Boolean PinchAction = null;

    public SteamVR_Action_Skeleton SkeletonAction = null;

    private void Update()
    {
        //Thumbstick();
        //Trackpad();
        //Squeeze();

        Grip();
        Pinch();
        Skeleton();

    }

    private void Thumbstick()
    {
        if (ThumbstickAction.axis == Vector2.zero)
            return;

        print("Thumbstick: " + ThumbstickAction.axis);
    }

    private void Trackpad()
    {
        if (TrackpadAction.axis == Vector2.zero)
            return;

        print("Trackpad: " + TrackpadAction.axis);
    }

    private void Squeeze()
    {
        if (SqueezeAction.axis == 0.0f)
            return;

        print("Squeeze: " + SqueezeAction.axis);
    }


    private void Grip()
    {
        if (GripAction.stateDown)
            print("Grip Down");

        if (GripAction.stateUp)
            print("Grip Up");
    }

    private void Pinch()
    {
        if (PinchAction.stateDown)
            print("Pinch Down");

        if (PinchAction.stateUp)
            print("Pinch Up");
    }

    private void Skeleton()
    {
        // https://valvesoftware.github.io/steamvr_unity_plugin/articles/Skeleton-Input.html
        // float[] allCurls = SkeletonAction.fingerCurls;

        if (SkeletonAction.indexCurl != 0.0f)
            print("Index: " + SkeletonAction.indexCurl);

        if (SkeletonAction.middleCurl != 0.0f)
            print("Middle: " + SkeletonAction.middleCurl);

        if (SkeletonAction.ringCurl != 0.0f)
            print("Ring: " + SkeletonAction.ringCurl);

        if (SkeletonAction.pinkyCurl != 0.0f)
            print("Pinky: " + SkeletonAction.pinkyCurl);

        if (SkeletonAction.thumbCurl != 0.0f)
            print("Thumb: " + SkeletonAction.thumbCurl);
    }
}