using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform[] _respawnPoints;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with "+ other.name);
        if (other.gameObject.CompareTag("Player 1"))
        {
            Debug.Log("Found");
            other.transform.position = _respawnPoints[0].position;
            other.transform.rotation = new Quaternion(0, 0, 0, 1);
            //print("BOZO");
        }
        else if (other.gameObject.CompareTag("Player 2"))
        {
            other.transform.position = _respawnPoints[1].position;
        }
        //if (other.gameObject.CompareTag("Player 3"))
        //{
        //    other.transform.position = _respawnPoints[2].position;
        //}
        //if (other.gameObject.CompareTag("Player 4"))
        //{
        //    other.transform.position = _respawnPoints[3].position;
        //}
    }
}
