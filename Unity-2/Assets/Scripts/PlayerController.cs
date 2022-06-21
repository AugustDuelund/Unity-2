using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]

    private float moveSpeed;

    [SerializeField]

    private float lookSensitivity;

    [SerializeField]

    private float jumpHeight;

    [SerializeField]

    private float gravity;

    private Vector2 moveVector;

    private Vector2 lookVector;

    private Vector3 rotation;

    private float verticalVelocity;

    private CharacterController characterController;

    private Animator animator;

    

    Vector3 originalPos;
    // Start is called before the first frame update
    //Fetches our character controller and animator controller stuff
    void Start()
    {

        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    //Calls movement functions once per frame
    void Update()
    {

        Move();
        Rotate();
        
    }

    //Animates movement
    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
        if(moveVector.magnitude > 0)
        {
            animator.SetBool("isRunning", true);
        }
        else 
        {
            animator.SetBool("isRunning", false);   
        }
    }

    //Calculates movement
    private void Move()
    {

        verticalVelocity += -gravity*Time.deltaTime;

        if(characterController.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -0.1f*gravity*Time.deltaTime;
        }

        Vector3 move = transform.right*moveVector.x + transform.forward*moveVector.y + transform.up*verticalVelocity;
        characterController.Move(move*moveSpeed*Time.deltaTime);
    }

    
    public void OnLook(InputAction.CallbackContext context)
    {
        lookVector = context.ReadValue<Vector2>();
    }

    //Calculates camera/player turning/rotation
    private void Rotate()
    {
        rotation.y += lookVector.x*lookSensitivity*Time.deltaTime;
        transform.localEulerAngles = rotation;
    }

    //Plays jump animation and calls jump function.
    public void OnJump(InputAction.CallbackContext context)
    {
        if(characterController.isGrounded && context.performed)
        {
            animator.Play("Jump");
            Jump();
        }
    }

    //Jump function, calculates player jump height.
    private void Jump()
    {
        verticalVelocity = Mathf.Sqrt(jumpHeight*gravity);
    }

}
