using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    Vector2 moveDirection;


    public static Shooter_Game_IS _inputActionShooter;

    // Start is called before the first frame update
    void Start()
    {
        _inputActionShooter = new Shooter_Game_IS();

        _inputActionShooter.Game.Enable();

        _inputActionShooter.Game.Move.performed += Move;
        _inputActionShooter.Game.Move.canceled += MoveCanceled;
    }

    private void MoveCanceled(InputAction.CallbackContext obj)
    {
        moveDirection = Vector2.zero;
    }

    private void Update()
    {
        Moove(new Vector3(moveDirection.x, moveDirection.y, 0f ));
    }

    // Update is called once per frame
    /* void FixedUpdate()
     {
         thisRB.MovePosition(thisRB.position + input * move * Time.fixedDeltaTime);
     }*/
    public void Move(InputAction.CallbackContext context)
    {
        moveDirection = _inputActionShooter.Game.Move.ReadValue<Vector2>();
    }
    public void Moove(Vector3 moveDirection)
    {
     
        transform.Translate(moveDirection * Time.deltaTime * 5);
    }
}