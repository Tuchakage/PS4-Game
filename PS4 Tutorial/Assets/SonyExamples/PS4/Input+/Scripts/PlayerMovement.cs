using UnityEngine;
using UnityEngine.PS4;
using System;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour 
{
	public Rigidbody Rb;
	public LayerMask groundLayer; //So we know what the Ground is (Objects With the ground layer)
	public SphereCollider col;
	public float forwardAccel = 2f, speed, turnStrength = 180, jumpForce = 7;
	private float speedInput, turnInput;

	private int score;

	public float sensH = 10;
	public float sensV = 10;

    public int playerId;
	bool flickedonce; //Makes it so that you can only flick once

	// Use this for initialization
	void Start () 
	{
		score = 0;
        PS4Input.PadResetOrientation(playerId);

		Rb.transform.parent = null;
    }

	void Update()
	{
		// If we are not pressing anything make the speed always 0
		speedInput = 0;
		turnInput = 0;
		if (PS4Input.PadIsConnected(playerId)) 
		{
			// When we press the X button then change the speed value 
			KeyCode code2 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick1Button0", true);
			if (Input.GetKey(code2))
			{
				speedInput = 1* forwardAccel * 500;
			}
		}

		//Player model will follow the Rigid Body Of The Sphere
		transform.position = Rb.transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//If the speedInput is not 0 (button has been pressed) then apply the movement
		if (speedInput > 0) 
		{
			//Move Rigid body Forward
			Rb.AddForce(transform.forward * speedInput);
		}

		if (PS4Input.PadIsConnected(playerId))
        {
			// Circle Button...
			KeyCode code = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick1Button1", true);
			if (Input.GetKey(code)) 
			{
                Rb.transform.position = new Vector3(1.98430276f, 0.730000019f, 0.589999974f);
                Rb.transform.rotation = new Quaternion(0, 0, 0, 1);

                PS4Input.PadResetOrientation(playerId);
			}



			//Get The motion Sensors
			Vector4 v = PS4Input.PadGetLastOrientation(0);
			Vector4 checkForFlick = new Vector4(0.5f, 0, 0, 0);
			Vector4 checkForTilt = new Vector4(0, 0, 0.5f, 0);

			//Jumping Controls
			//When i flick the controller up it will reset the position of the Cube and the Controller hasnt been flicked yet
			if (v.x > checkForFlick.x && !flickedonce && isGrounded())
			{
				//Before launching Player into air change the Rigidbody values so that they can jump and fall down properly
				Rb.mass = 1;
				Rb.drag = 0;
				Rb.angularDrag = 0.05f;
				Rb.interpolation = RigidbodyInterpolation.Interpolate;
				Rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);



				//Tell the game that the controller has been flicked
				flickedonce = true;
				Debug.Log("Flicked Up");
				//maincamera.transform.localPosition = new Vector3(-0.00999999046f, 1.00999999f, -2.32999992f);
			}
			else if (v.x <= checkForFlick.x && flickedonce) //If the Controller is pack to its original position and its already been flicked
			{
				//Make it so that we can flick the controller up again
				flickedonce = false;
			}

			//If the player is on the ground then make sure you revert rigidbody
			if (isGrounded()) 
			{
				RevertRigidbody();
			}

			//Steering Controls
			//Tilting to the right
			if (v.z < -checkForTilt.z)
			{
				turnInput = 1;
				//Debug.Log(transform.rotation);
			}
			else if (v.z > checkForTilt.z)//Titlting To The left
			{
				turnInput = -1;
				//Debug.Log(transform.rotation);
			}

			transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, turnInput * turnStrength * Time.deltaTime, 0));

			//Debug.Log("Stick: " + v);


			//Movement from before
			//float moveHor = Mathf.Clamp(v.z * sensH, -1, 1);
			//float moveVer = Mathf.Clamp(v.x * sensV, -1, 1);
			//GetComponent<Rigidbody>().AddForce(new Vector3 (-moveHor, 0, -moveVer) * speed * Time.deltaTime);
		}
    }
	


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			score += 10;
		}
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
