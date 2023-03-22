using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Texture _texture;
    [SerializeField] private int _index;

    public string GetName { get { return _name; } }
    public Texture GetTexture { get { return _texture; } }
    public int GetSetID { get { return _index; } set { _index = value; } }
}