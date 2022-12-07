using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerListener : MonoBehaviour
{
    [SerializeField]
    private ScriptablePlayerEvent _scripatblePlayerEvent;

    public void Awake()
    {
        _scripatblePlayerEvent.Move += OnMove;
        _scripatblePlayerEvent.Jump += OnJump;
    }

    private void OnMove(Vector2 value)
    {
        Debug.Log("move : "+ value);
    }
    private void OnJump()
    {
        Debug.Log("jump : " );
    }
}
