using UnityEngine;
using UnityEngine.PS4;
using System;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            if (PS4Input.PadIsConnected(0) || PS4Input.PadIsConnected(1))
            {
                KeyCode CrossP1 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick1Button0", true);
                KeyCode CrossP2 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick2Button0", true);
                if (Input.GetKey(CrossP1) || Input.GetKey(CrossP2))
                {
                    SceneManager.LoadScene(1);
                }
            }
        }
        else 
        {
            if (PS4Input.PadIsConnected(0) || PS4Input.PadIsConnected(1))
            {
                KeyCode CircleP1 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick1Button1", true);
                KeyCode CircleP2 = (KeyCode)Enum.Parse(typeof(KeyCode), "Joystick2Button1", true);
                if (Input.GetKey(CircleP1) || Input.GetKey(CircleP2))
                {
                    SceneManager.LoadScene(0);
                }
            }
        }

    }
}
