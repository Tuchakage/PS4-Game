using UnityEngine;
using UnityEngine.PS4;
using System;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour 
{
	Animator anim;
	public Transform enemyTarget;
	
	public Rigidbody Rb;
	public LayerMask groundLayer; //So we know what the Ground is (Objects With the ground layer)
	public SphereCollider col;
	public float forwardAccel = 2f, reverseAccel, speed, turnStrength = 180, jumpForce = 7;
	private float speedInput, turnInput;

	private int score;

	public float sensH = 10;
	public float sensV = 10;

    public int playerId;
	int controllerId; //To show the different controllers
	bool flickedonce; //Makes it so that you can only flick once
	bool launched; // Checks if the Player has been launched
	public int checkpoints; //Indicates Which Checkpoint the player is at
	Color m_LightbarColour;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		checkpoints = 1;
		launched = false;
		score = 0;
        PS4Input.PadResetOrientation(playerId);
		controllerId = playerId + 1;

		Rb.transform.parent = null;
		Debug.Log(playerId);


	}

	void Update()
	{
		// If we are not pressing anything make the speed always 0
		speedInput = 0;
		turnInput = 0;
		if (anim != null) 
		{
			anim.SetBool("isRunning", false);
		}
		
		if (PS4Input.PadIsConnected(playerId)) 
		{
			// When we press the X button then change the speed value 
			KeyCode code2 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick" + controllerId + "Button0", true);

			// When we press the Circle button then change the speed value 
			KeyCode code3 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick" + controllerId + "Button1", true);
			if (Input.GetKey(code2))
			{
				speedInput = 1 * forwardAccel * speed;
				//Set the Controller Colour To Yellow
				SetControllerColour(ColourChangeDepsController(playerId));
				anim.SetBool("isRunning", true);

			}
			else if (Input.GetKey(code3)) 
			{
				speedInput = -1 * reverseAccel * speed;
				anim.SetBool("isRunning", true);
			}

			if (speedInput == 0) 
			{
				anim.SetBool("isRunning", false);
			}


			//Player model will follow the Rigid Body Of The Sphere
			transform.position = Rb.transform.position;
		}


	}

	// Update is called once per frame
	void FixedUpdate () 
	{


		if (PS4Input.PadIsConnected(playerId))
        {
			if (this.gameObject.tag == "Player 1") // If the Trap Master
			{
				if (speedInput > 0)
				{
					//Move Rigid body Forward
					Rb.AddForce(transform.right * speedInput);
				}
				else
				{
					//Move Rigid body Backwards
					Rb.AddForce(transform.right * speedInput);
				}
			}
			else //If not the Trap Master
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

				//Get The motion Sensors
				Vector4 v = PS4Input.PadGetLastOrientation(playerId);
				Vector4 checkForFlick = new Vector4(0.3f, 0, 0, 0);
				Vector4 checkForTilt = new Vector4(0, 0, 0.2f, 0);

				//Jumping Controls
				//When i flick the controller up it will reset the position of the Cube and the Controller hasnt been flicked yet
				if (v.x > checkForFlick.x && !flickedonce && isGrounded())
				{
					//Before launching Player into air change the Rigidbody values so that they can jump and fall down properly
					Rb.mass = 1;
					Rb.drag = 0;
					Rb.angularDrag = 0.05f;
					Rb.interpolation = RigidbodyInterpolation.Interpolate;
					//Make the Player jump
					Rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

					playJumpSound();

					//Tell the game that the controller has been flicked
					flickedonce = true;
					Debug.Log("Flicked Up");
					//maincamera.transform.localPosition = new Vector3(-0.00999999046f, 1.00999999f, -2.32999992f);
				}
				else if (v.x <= checkForFlick.x && flickedonce) //If the Controller is back to its original position and its already been flicked
				{
					//Make it so that we can flick the controller up again
					flickedonce = false;
				}

				//Homing Dash if the Player is in the air and there is a target
				if (v.x < -0.4f && !isGrounded() && enemyTarget != null && !launched)
				{
					//Debug.Log("works");
					//Find the Direction to the Enemy
					Vector3 direction = enemyTarget.position - Rb.gameObject.transform.position;
					//Launch the Player towards the Enemy
					Rb.AddForce(direction * 50000f);
					launched = true;

				}
				//If the player is on the ground then make sure you revert rigidbody
				if (isGrounded())
				{
					RevertRigidbody();
					//Player has not been launched which means it can still be launched when in mid air
					launched = false;
				}

				//Steering Controls
				turnInput = -v.z;

				//Depending on how much the controller is turned 
				if (turnInput < -0.1 || turnInput > 0.1 && isGrounded())
				{
					//Actually Steer the player
					transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, turnInput * turnStrength * Time.deltaTime, 0));
				}
			}


            // Option Key
            KeyCode code = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick" + controllerId + "Button7", true);
            if (Input.GetKey(code))
            {
                //Rb.transform.position = new Vector3(1.98430276f, 0.730000019f, 0.589999974f);
                //Rb.transform.rotation = new Quaternion(0, 0, 0, 1);

                PS4Input.PadResetOrientation(playerId);
            }





		}
    }
	
	//Revert The Rigidbody values once the Player is back on the ground
	void RevertRigidbody() 
	{
		Rb.mass = 70;
		Rb.drag = 3;
		Rb.angularDrag = 4;
		Rb.interpolation = RigidbodyInterpolation.None;
		//Debug.Log("Reverting");
	}

	//Check if the Player is on the ground or not
	private bool isGrounded() 
	{
		return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * 0.9f, groundLayer);
	}

	//Sets the Light Bar Colour To Controller
	void SetControllerColour(Color controllerColour) 
	{
		//Sets the Colour
		m_LightbarColour = controllerColour;

		//Changes the Colour On Controller
		PS4Input.PadSetLightBar(playerId,
		Mathf.RoundToInt(m_LightbarColour.r * 255),
		Mathf.RoundToInt(m_LightbarColour.g * 255),
		Mathf.RoundToInt(m_LightbarColour.b * 255));
	}

	//Colour Changes depends on Controller
	Color ColourChangeDepsController(int colorId)
	{
		//Colour Of Light depends on the Player Id number
		switch (colorId) 
		{
			case 0:
				return Color.yellow;
			case 1:
				return Color.green;
			default:
				return Color.white;
		}

	}

	void playJumpSound() 
	{
		//Plays Jump Sound On Speaker
		if (!GetComponent<AudioSource>().isPlaying)
			GetComponent<AudioSource>().PlayOnGamepad(playerId);
	}
}
