using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerManager : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] float _moveSpeed;
    Vector2 moveDirection;

    [SerializeField] string[] inventory= new string[5];

    [SerializeField] Inventory inventory2;

    void Start()
    {
        //set le rigidbody
        _rigidbody2D = GetComponent<Rigidbody2D>();

        //vide l'inventaire
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] != null)
            {
                inventory[i] = null;
            }
        }
    }

    private void Update()
    {
        //calcul la direction
        Moove(new Vector3(moveDirection.x, moveDirection.y, 0f));
    }
  
    //recois les input
    public void OnMove(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                Movement(context.ReadValue<Vector2>());  //renvoi la valeur recu par l'input
                break;
            case InputActionPhase.Canceled:
                moveDirection = Vector2.zero; //set le mouvement a zero
                break;
        }
    }

    //set la valeur "moveDirection", utilisé dans le update, pour la direction 
    void Movement(Vector2 value)
    {
        moveDirection = value;
    }

    //bouge le player
    public void Moove(Vector3 moveDirection)
    {
        transform.Translate(moveDirection * Time.deltaTime * 5);
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