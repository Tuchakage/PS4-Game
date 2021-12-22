using UnityEngine;
using UnityEngine.PS4;
using System;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour 
{
	public Camera maincamera;
	public float speed;
	private int score;

	public float forwardAccel = 2f;
	public float sensH = 10;
	public float sensV = 10;

    public int playerId;


	// Use this for initialization
	void Start () 
	{
		score = 0;
        PS4Input.PadResetOrientation(playerId);
    }
	
	// Update is called once per frame
	void FixedUpdate () 
	{
        if (PS4Input.PadIsConnected(playerId))
        {
			maincamera.transform.localRotation = new Quaternion(0.0995999947f, 0, 0, 0.995027602f);
			// Circle Button...
			KeyCode code = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick1Button1", true);
			if (Input.GetKey(code)) 
			{
				this.transform.position = new Vector3(1.98430276f, 0.730000019f, 0.589999974f);
				this.transform.rotation = new Quaternion(0, 0, 0, 0);
				PS4Input.PadResetOrientation(playerId);
			}

			// X Button...
			KeyCode code2 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick1Button0", true);
			if (Input.GetKey(code2))
			{
				GetComponent<Rigidbody>().AddForce(transform.forward * forwardAccel * 2);
				//Debug.Log("Pressed X");
			}

			//Get The motion Sensors
			Vector4 v = PS4Input.PadGetLastOrientation(0);
			Vector4 check = new Vector4(0.5f, 0, 0, 0);

			//When i flick the controller up it will reset the position of the Cube
			if (v.x > check.x) 
			{
				this.transform.position = new Vector3(1.98430276f, 0.730000019f, 0.589999974f);
				this.transform.rotation = new Quaternion(0, 0, 0, 1);
				//maincamera.transform.localPosition = new Vector3(-0.00999999046f, 1.00999999f, -2.32999992f);
			}
			//Debug.Log("Stick: " + v);


			//Movement from before
			//float moveHor = Mathf.Clamp(v.z * sensH, -1, 1);
			//float moveVer = Mathf.Clamp(v.x * sensV, -1, 1);
			//GetComponent<Rigidbody>().AddForce(new Vector3 (-moveHor, 0, -moveVer) * speed * Time.deltaTime);
		}
    }
	
	void Update()
	{
		for (int i = 0; i < Input.touchCount; i++) 
			if (Input.GetTouch (i).phase == TouchPhase.Began)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch (i).position);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, Mathf.Infinity, -1))
				if (hit.transform.gameObject.tag == "PickUp")
					hit.transform.gameObject.SetActive (false);
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
}
