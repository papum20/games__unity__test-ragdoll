using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private float sensibility = 6f;     //max rotation: (60 * sensibility) / second

    private float xMouseInput, yMouseInput;




    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    void Update()
    {
        //MOUSE INPUT
        xMouseInput = Input.GetAxis("Mouse X");
        yMouseInput = Input.GetAxis("Mouse Y");

        Debug.Log(xMouseInput);
        Debug.Log(yMouseInput);


    }

    private void FixedUpdate()
    {
        //ROTATE CAMERA
        Vector2 tmpRot = new Vector2(xMouseInput, yMouseInput);
        tmpRot *= sensibility;

        //Vector3 curRot = new Vector3( transform.eulerAngles;
        transform.RotateAround(player.position, player.up, tmpRot.x);
        transform.RotateAround(player.position, transform.right, -tmpRot.y);

        player.RotateAround(player.position, transform.right, -tmpRot.y);   //
        transform.LookAt(player.position);
    }

}
