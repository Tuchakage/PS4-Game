using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardAccel = 2f, speed, turnStrength = 180, jumpForce = 7;
    public SphereCollider col;
    public LayerMask groundLayer; //So we know what the Ground is (Objects With the ground layer)
    private float speedInput, turnInput;
    [SerializeField] Rigidbody Rb;
    
    //Controls
    [Header("Controls")] 
    [SerializeField] private KeyCode _moveFoward;
    [SerializeField] private KeyCode _jump;
    [SerializeField] private KeyCode _turnLeft;
    [SerializeField] private KeyCode _turnRight;
    
    // Start is called before the first frame update
    void Start()
    {
        Rb.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        // If we are not pressing anything make the speed always 0
        speedInput = 0;
        turnInput = 0;
        if (Input.GetKey(_moveFoward))
        {
            speedInput = 1 * forwardAccel * 500;
        }
        //Player model will follow the Rigid Body Of The Sphere
        transform.position = Rb.transform.position;
    }

    private void FixedUpdate()
    {
        //If the speedInput is not 0 (button has been pressed) then apply the movement
        if (speedInput > 0)
        {
            //Move Rigid body Forward
            Rb.AddForce(transform.forward * speedInput);
        }

        if (Input.GetKeyDown(_jump) && isGrounded()) 
        {
            //Before launching Player into air change the Rigidbody values so that they can jump and fall down properly
            Rb.mass = 1;
            Rb.drag = 0;
            Rb.angularDrag = 0.05f;
            Rb.interpolation = RigidbodyInterpolation.Interpolate;
            Rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //maincamera.transform.localPosition = new Vector3(-0.00999999046f, 1.00999999f, -2.32999992f);
        }
        //If the player is on the ground then make sure you revert rigidbody
        if (isGrounded())
        {
            RevertRigidbody();
        }

        if (Input.GetKey(_turnRight))
        {
            turnInput = 1;
            //Debug.Log(transform.rotation);
        }
        else if (Input.GetKey(_turnLeft))//Titlting To The left
        {
            turnInput = -1;
            //Debug.Log(transform.rotation);
        }

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, turnInput * turnStrength * Time.deltaTime, 0));
    }

    //Revert The Rigidbody values once the Player is back on the ground
    void RevertRigidbody()
    {
        Rb.mass = 70;
        Rb.drag = 3;
        Rb.angularDrag = 4;
        Rb.interpolation = RigidbodyInterpolation.None;
    }

    private bool isGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * 0.9f, groundLayer);
    }

    private void OnDrawGizmos()
    {
        if (gameObject.CompareTag($"Player 1"))
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, 1);
        }
        else if (gameObject.CompareTag($"Player 2"))
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(transform.position, 1);
        }
        else if (gameObject.CompareTag($"Player 3"))
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(transform.position, 1);
        }
        else if (gameObject.CompareTag($"Player 4"))
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(transform.position, 1);
        }

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, 1.1f);
    }
}
