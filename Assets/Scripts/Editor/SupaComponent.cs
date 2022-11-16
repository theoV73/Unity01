using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
[SelectionBase]
public class SupaComponent : MonoBehaviour
{
    
    [SerializeField, Range(0,10)] 
    private float HealthValue;

    [SerializeField, Range(0,10)] 
    private float ManaValue;

    [SerializeField] string name1;
}
