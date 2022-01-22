using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform[] _respawnPoints;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player 2"))
        {
            other.transform.position = _respawnPoints[0].position;
            //Player loses a Life
            other.GetComponent<Owner>().owner.GetComponent<Lives>().LoseALife();
        }


    }
}
