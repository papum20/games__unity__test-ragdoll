using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;
    private float moveSpeed = 6f;



    void Update()
    {
        //GET INPUT
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveInput.Normalize();
    }

    private void FixedUpdate()
    {
        //MOVE
        Vector2 moveVector = moveInput * moveSpeed * Time.fixedDeltaTime;
        transform.Translate(moveVector.x, 0, moveVector.y);
    }


}
