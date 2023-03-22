using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLibrary : MonoBehaviour
{
    [SerializeField] Item[] item;

    public void SetIDItems()
    {
        for (int i = 0; i < item.Length; i++)
        {
            item[i].GetSetID = i;
        }
    }
}
