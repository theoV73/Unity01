using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    private GameInputAction inpu;
    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("jump");
        switch (context.phase)
        {
            case InputActionPhase.Started:
                Debug.Log("Started");
                break;
            case InputActionPhase.Performed:
                Debug.Log("Performed");
                break;
            case InputActionPhase.Canceled:
                Debug.Log("Canceled");
                break;
            default:
                break;
        }
    }
}
