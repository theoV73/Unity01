using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerManager : MonoBehaviour
{
    PlayerMovement playerMovement;

    [SerializeField] string[] inventory= new string[5];

    [SerializeField] Inventory inventory2;

    void Start()
    {
        //set le rigidbody

        //vide l'inventaire
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] != null)
            {
                inventory[i] = null;
            }
        }
    }

    //recois les input
    public void OnMove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                //Movement(context.ReadValue<Vector2>());  //renvoi la valeur recu par l'input
                playerMovement.Movement(context.ReadValue<Vector2>());
                break;
            case InputActionPhase.Canceled:
                //moveDirection = Vector2.zero; //set le mouvement a zero
                playerMovement.GetMoveDirection = Vector2.zero;
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //si il touche un objet interactable, alors il regarde si il reste de place dans l'inventaire, si oui, il ajoute l'objet a l'inventaire
        if (collision.gameObject.layer == 7)
        {
            WhatItem currentItem = collision.gameObject.GetComponent<WhatItem>();
            inventory2.AddItem(currentItem.GetItem);

            /*for (int i = 0; i < inventory.Length; i++)
            {
                Debug.Log(inventory[i]);
                Debug.Log(inventory.Length);
                if (inventory[i] == null)
                {
                    inventory[i] = collision.gameObject.GetComponent<WhatItem>().GetItem.GetName;
                    return;
                }
            }*/
        }
    }
}