using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.PS4;
using UnityEngine;

public class ActivateTraps : MonoBehaviour
{

    public Animator _trapAnimA;
    public Animator _trapAnimB;
    public Animator _trapAnimCLeft;
    public Animator _trapAnimCRight;

    public bool isTrapActivated;
    public bool canTrapBeActivated;

    public bool isTrapCActivated;
    public bool canTrapCBeActivated;

    public RotatePlatform[] _rpList;
    public int playerId;
    int controllerId; //To show the different controllers

    float timer;

    private void Start()
    {
        isTrapActivated = false;
        isTrapCActivated = false;
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
                        StartCoroutine(StartVibration());
                        Debug.Log("Trap A Activated");
                    }

                    if (Math.Abs(Input.GetAxis("joystick1_right_trigger")) > 0.001f)
                    {
                        Debug.Log("R2");
                        isTrapActivated = true;
                        _trapAnimB.SetTrigger("TrapBDown");
                        _trapAnimA.enabled = false;
                        StartCoroutine(StartVibration());
                        Debug.Log("Trap B Activated");
                    }

                }

                canTrapCBeActivated = true;
                if (gameObject.CompareTag("TrapC"))
                {
                    DecreaseTimer();

                    if (timer <= 0)
                    {
                        if (Math.Abs(Input.GetAxis("joystick1_left_trigger")) > 0.001f)
                        {
                            isTrapCActivated = true;
                            SetTimer();
                            _trapAnimCLeft.SetTrigger("ATrapGoRight");
                            _trapAnimCRight.SetTrigger("BTrapGoLeft");
                            StartCoroutine(StartVibration());

                        }
                    }
                }

                if (gameObject.CompareTag("TrapC"))
                {
                    DecreaseTimer();

                    if (timer <= 0)
                    {
                        if (Math.Abs(Input.GetAxis("joystick1_right_trigger")) > 0.001f)
                        {
                            isTrapCActivated = true;
                            SetTimer();
                            _trapAnimCLeft.SetTrigger("ATrapGoLeft");
                            _trapAnimCRight.SetTrigger("BTrapGoRight");
                            StartCoroutine(StartVibration());

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
                canTrapCBeActivated = false;
            }
        }

        void ChangeRotateSpeed()
        {
            for (int i = 0; i < _rpList.Length; i++)
            {
                _rpList[i].rotationSpeed = 50f;
            }
        }

        IEnumerator StartVibration()
        {
            PS4Input.PadSetVibration(playerId, 50, 100);
            yield return new WaitForSeconds(1);
            PS4Input.PadSetVibration(playerId, 0, 0);

        }

        void DecreaseTimer()
        {
            timer -= Time.deltaTime;
        }

        void SetTimer()
        {
            timer = 3f;
        }
    }
}
