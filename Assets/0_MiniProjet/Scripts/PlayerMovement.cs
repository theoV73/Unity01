using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    Vector2 moveDirection;
    public Vector2 GetMoveDirection
    {
        get { return moveDirection; }
        set { moveDirection = value; }
    }
    private void Update()
    {
        //calcul la direction
        Moove(new Vector3(moveDirection.x, moveDirection.y, 0f));
    }
    public void Movement(Vector2 value)
    {
        moveDirection = value;
    }
    public void Moove(Vector3 moveDirection)
    {
        transform.Translate(moveDirection * Time.deltaTime * 5);
    }
}
