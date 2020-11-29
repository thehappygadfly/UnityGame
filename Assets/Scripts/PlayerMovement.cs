using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public Transform groundCheck;
    

    public LayerMask groundmask;
    public float groundDistance = 0.4f;
    public float speed = 2f;
    private float gravity = -9.8f;
    public float jumpHeight = 3f;
    public float walkSpeed = 2f;
    public float runSpeed = 10f;
    private float rotateSpeed = 10f;

    public Animator movement;
    public Animator woodchest;

    Vector3 velocity;
    bool isGrounded;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundmask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }

        // if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = walkSpeed;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            movement.SetBool("AttackJ", true);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            movement.SetBool("AttackJ", false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            movement.SetBool("AttackK", true);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            movement.SetBool("AttackK", false);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            movement.SetBool("AttackL", true);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            movement.SetBool("AttackL", false);
        }

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            // velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
            movement.SetBool("Jump", true);
        }

        if (Input.GetButtonUp("Jump"))
        {
            movement.SetBool("Jump", false);
        }

        Vector3 targetDir = new Vector3(x, 0, z);
        Quaternion newRotation = Quaternion.LookRotation(targetDir, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotateSpeed * Time.deltaTime);

        movement.SetFloat("Speed", (move * speed).magnitude);



    }
}
