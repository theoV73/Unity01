using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    [SerializeField]
    private EventHandler _eventHandler;

    [SerializeField]
    private UnityEvent OnTriggerInvoked;

    private void Start()
    {
        _eventHandler.Event += Jump;

        //fonction anonyme / lambda
        _eventHandler.Event += (float value) => OnTriggerInvoked?.Invoke();
    }

    private void Jump(float value)
    {
        Debug.Log($"Jump int value = {value}");
    }
}
