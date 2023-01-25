using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatItem : MonoBehaviour
{
    [SerializeField] Item item;

    [SerializeField] int poids;

    public Item GetItem { get { return item; } }

    private void Disapear()
    {
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Disapear();
        }
    }

}
