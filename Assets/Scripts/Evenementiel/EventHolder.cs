using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public event Action<float> Event;

    private void Update()
    {
        Event.Invoke(Time.deltaTime);
    }
}
