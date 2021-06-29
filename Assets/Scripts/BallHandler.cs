using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandler : MonoBehaviour
{
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            return;
        }
        else
        {
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            Debug.Log(touchPosition);
        }
    }
}