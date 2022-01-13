using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTraps : MonoBehaviour
{

    public Animator TrapAAnim;
    public Animator TrapBAnim;

    public bool isTrapActivated;
    public bool canTrapBeActivated;

    public List<RotatePlatform> _rpList;
    
    private void Start()
    {
        isTrapActivated = false;
        canTrapBeActivated = true;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Player 4") && !isTrapActivated)
        {
            canTrapBeActivated = true;
            if (gameObject.CompareTag("TrapA"))
            {
                TrapAAnim.SetTrigger("TrapADown");
                isTrapActivated = true;
            }

            if (gameObject.CompareTag("TrapB"))
            {
                TrapBAnim.SetTrigger("TrapBDown");
                isTrapActivated = true;
            }

            if (gameObject.CompareTag("TrapC"))
            {
                for (int i = 0; i < _rpList.Count; i++)
                {
                    _rpList[i].rotationSpeed = 50;
                }
            }
        }
    }
}
