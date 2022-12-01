using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="new_ScriptableEvent", menuName = "Events/Scriptable Event")]
public class ScriptableEvent : ScriptableObject
{
    public event Action Event;

    public void Invoke()=> Event?.Invoke();
}
