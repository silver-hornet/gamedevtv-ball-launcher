using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandler : MonoBehaviour
{
    [SerializeField] Rigidbody2D currentBallRigidbody;
    Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            currentBallRigidbody.isKinematic = false;
            return;
        }
        else
        {
            currentBallRigidbody.isKinematic = true;
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);
            currentBallRigidbody.position = worldPosition;
        }
    }
}
