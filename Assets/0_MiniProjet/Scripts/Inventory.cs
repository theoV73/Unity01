using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Inventory")]
public class Inventory : ScriptableObject
{
    [SerializeField] List<Item> _items;
    public Action<int, Item> OnItemAdded;

    public void AddItem(Item itemToAdd)
    {
        _items.Add(itemToAdd);
        OnItemAdded?.Invoke(_items.Count - 1, itemToAdd);
    }

    public void Clear()
    {
        _items.Clear();
        OnItemAdded = null;
    }
}
