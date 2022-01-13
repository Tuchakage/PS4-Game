using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTraps : MonoBehaviour
{

    public Animator _trapAnimA;
    public Animator _trapAnimB;
    

    public bool isTrapActivated;
    public bool canTrapBeActivated;
    

    public RotatePlatform[] _rpList;
    
    
    private void Start()
    {
        isTrapActivated = false;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (!isTrapActivated)
        {
            canTrapBeActivated = true;
            if (other.gameObject.CompareTag("Player 4"))
            {
                if (gameObject.CompareTag("TrapC"))
                {
                    isTrapActivated = true;
                    ChangeRotateSpeed();
                }
                else if (gameObject.CompareTag("TrapA"))
                {
                    isTrapActivated = true;
                    _trapAnimA.SetTrigger("TrapADown");
                    _trapAnimB.enabled = false;
                }
                else if (gameObject.CompareTag("TrapB"))
                {
                    isTrapActivated = true;
                    _trapAnimB.SetTrigger("TrapBDown");
                    _trapAnimA.enabled = false;
                }
            }
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
