using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlMove : MonoBehaviour
{
    //this code taken from: https://youtu.be/b1uoLBp2I1w?si=VEFj1J2rusXrIhgv
    //i dont fully understand it
    //camera issue is in here i think, left and right mouse movement makes you look up

    
    private float xRot;
    private Vector2 PlayerMouseInput;
    private Vector3 PlayerMovementInput;
    private Vector3 Velocity;
   
    [SerializeField] private CharacterController Controller;
    [SerializeField] private Transform PlayerCamera;
    [Space]
    [SerializeField] private float Speed;
    [SerializeField] private float Sensitivity;
    [SerializeField] private float Jumpforce;
    [SerializeField] private float Gravity = 9.81f;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMouseInput = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer();
        MovePlayerCamera();

    }
    
    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput);
        //this might only work with jumping but atm idk if i will be doing that. 
        //im just trying to get the collision to work so the primary premise works
        //cant find little ghost cats lost in a maze if walls dont wall
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Velocity.y = Jumpforce;        
        }
        if(Controller.isGrounded)
        {
            Velocity.y = -1f;
        }
        else 
        {
            Velocity.y -= Gravity * -2f * Time.deltaTime;
        }

        Controller.Move(MoveVector * Speed * Time.deltaTime);
        Controller.Move(Velocity * Time.deltaTime);
    }

    private void MovePlayerCamera() //mouse rotate, maybe swap with the smooth controller?
    {
        //this is whats breaking it but i dont know why it is suddenly
        //tried rotating camera and other stuff
        //xRot -= PlayerMouseInput.y * Sensitivity;

        //transform.Rotate(0f, PlayerMouseInput.x * Sensitivity, 0f);
        //PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }

}
