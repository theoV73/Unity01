using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Texture _texture;

    public string GetName { get { return _name; } }
    public Texture GetTexture { get { return _texture; } }
}