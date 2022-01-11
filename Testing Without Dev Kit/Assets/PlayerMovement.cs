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
        if (Input.GetKey(KeyCode.W))
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

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded()) 
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

        if (Input.GetKey(KeyCode.D))
        {
            turnInput = 1;
            //Debug.Log(transform.rotation);
        }
        else if (Input.GetKey(KeyCode.A))//Titlting To The left
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
}
