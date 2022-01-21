using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;
    public Transform enemyTarget;
    public float forwardAccel = 2f, reverseAccel = 2, turnStrength = 180, jumpForce = 7;
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
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // If we are not pressing anything make the speed always 0
        speedInput = 0;
        anim.SetBool("isRunning", false);
        turnInput = 0;
        if (Input.GetKey(_moveFoward))
        {
            speedInput = 1 * forwardAccel * 500;
            anim.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.S)) 
        {
            speedInput = -1 * reverseAccel * 500;
            anim.SetBool("isRunning", true);
        }

        if (speedInput == 0) 
        {
            anim.SetBool("isRunning", false);
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

        // Distance between enemy and player
        float distFromPlayer = Vector3.Distance(enemyTarget.position, Rb.gameObject.transform.position);

        //Homing Dash if the Player is in the air, there is a target and the player is within 5m of the target.
        if (Input.GetKeyDown(KeyCode.K) && !isGrounded() && enemyTarget != null && distFromPlayer <= 10f) 
        {
            //Find the Direction to the Enemy
            Vector3 direction = enemyTarget.position - Rb.gameObject.transform.position;
            //Launch the Player towards the Enemy
            Rb.AddForce(direction * 50000f);

        }
        //If the player is on the ground then make sure you revert rigidbody
        if (isGrounded())
        {
            RevertRigidbody();
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
        else 
        {
            //Move Rigid body Backwards
            Rb.AddForce(transform.forward * speedInput);
        }



        if (Input.GetKey(_turnRight) && isGrounded())
        {
            turnInput = 1;
            //Debug.Log(transform.rotation);
        }
        else if (Input.GetKey(_turnLeft) && isGrounded())//Titlting To The left
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
        Rb.drag = 1;
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
            Gizmos.DrawSphere(transform.position, 0.6f);
        }
        else if (gameObject.CompareTag($"Player 2"))
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(transform.position, 0.6f);
        }
        else if (gameObject.CompareTag($"Player 3"))
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(transform.position, 0.6f);
        }
        else if (gameObject.CompareTag($"Player 4"))
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(transform.position, 0.6f);
        }

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, 0.75f);
    }
}
