using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableEventListener : MonoBehaviour
{
    [SerializeField]
    private ScriptableEvent _scripatbleEvent;

    private void Start()
    {
        _scripatbleEvent.Event += Callback;
    }

    private void Callback()
    {
        throw new NotImplementedException();
    }
}
