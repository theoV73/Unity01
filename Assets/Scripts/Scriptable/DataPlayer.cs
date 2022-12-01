using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName ="new_DataPlayer",menuName ="Data/DataPlayer")]
public class DataPlayer : ScriptableObject 
{
    public event Action LifePointChanged;

    [SerializeField]
    private string _name;
    public string Name => _name;

    [SerializeField]
    private int _lifePoints;
    public int LifePoints => _lifePoints;

    private int _currentlifePoints;

    public int CurrentLifePoints
    {
        get => _currentlifePoints;
        set
        {
            _currentlifePoints = Mathf.Clamp(value, 0, _lifePoints);
            LifePointChanged?.Invoke();
        }
    }
    private void OnEnable()
    {
        _currentlifePoints = _lifePoints;
    }
    private static void CreatePlayer()
    {

    }
}
