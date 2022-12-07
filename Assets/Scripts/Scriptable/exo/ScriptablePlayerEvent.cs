using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_ScriptableEvent", menuName = "Events/Scriptable Player Event")]
public class ScriptablePlayerEvent : ScriptableObject
{
    public event Action<Vector2> Move;
    public event Action Jump;

    Vector2 movement;

    public void InvokeMove(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            movement = context.ReadValue<Vector2>();
            Move?.Invoke(movement);
        }
        
    }
    public void InvokeJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Jump?.Invoke();
        }
            
    }
}
      
    

