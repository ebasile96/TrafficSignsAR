using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        //CheckFocus();
    }

    public void CheckFocus()
    {
        if (Input.touchCount > 0)
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
        }
    }
}
