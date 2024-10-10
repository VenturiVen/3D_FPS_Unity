using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController charController;
    private Vector3 playerVelocity;
    public float speed = 6f;
    public float gravity = -9.8f;

    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // receives inputs from InputManager.cs and applies them to charController
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = input.x;
        moveDir.z = input.y;
        charController.Move(transform.TransformDirection(moveDir) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        charController.Move(playerVelocity * Time.deltaTime);

        Debug.Log(playerVelocity.y);
    }
}
