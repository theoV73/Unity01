using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class LifePointUI : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private DataPlayer _dataPlayer;
    private void Awake()
    {
      _slider = GetComponent<Slider>();   
    }
    private void Start()
    {
        _dataPlayer.LifePointChanged += OnLifePointChange;
        OnLifePointChange();
    }

    private void OnLifePointChange()
    {
        _slider.value = (float)_dataPlayer.CurrentLifePoints/ _dataPlayer.LifePoints;
    }
}
