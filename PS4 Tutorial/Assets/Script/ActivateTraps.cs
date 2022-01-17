using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.PS4;
using UnityEngine;

public class ActivateTraps : MonoBehaviour
{

    public Animator _trapAnimA;
    public Animator _trapAnimB;
    

    public bool isTrapActivated;
    public bool canTrapBeActivated;
    

    public RotatePlatform[] _rpList;
    public int playerId;
    int controllerId; //To show the different controllers

    private void Start()
    {
        isTrapActivated = false;
        controllerId = playerId + 1;
    }
    

    private void OnTriggerStay(Collider other)
    {
        if (!isTrapActivated)
        {

            canTrapBeActivated = true;
            if (other.gameObject.CompareTag("Player 4"))
            {

                if (gameObject.CompareTag("TrapA"))
                {
                    if (Math.Abs(Input.GetAxis("joystick1_left_trigger")) > 0.001f)
                    {
                        isTrapActivated = true;
                        _trapAnimA.SetTrigger("TrapADown");
                        _trapAnimB.enabled = false;
                        Debug.Log("Trap A Activated");
                    }

                    if (Math.Abs(Input.GetAxis("joystick1_right_trigger")) > 0.001f)
                    {
                        Debug.Log("R2");
                        isTrapActivated = true;
                        _trapAnimB.SetTrigger("TrapBDown");
                        _trapAnimA.enabled = false;
                        Debug.Log("Trap B Activated");
                    }

                }
            }



            //if (Input.GetKey(codeL2))
            //{
            //    Debug.Log("Pressed L2");
            //    if (gameObject.CompareTag("TrapB"))
            //    {
            //        isTrapActivated = true;
            //        _trapAnimB.SetTrigger("TrapBDown");
            //        _trapAnimA.enabled = false;
            //    }

            //}

        }
        else
        {
            isTrapActivated = true;
            canTrapBeActivated = false;
        }
    }

    void ChangeRotateSpeed()
    {
        for (int i = 0; i < _rpList.Length; i++)
        {
            _rpList[i].rotationSpeed = 50f;
        }
    }
}
