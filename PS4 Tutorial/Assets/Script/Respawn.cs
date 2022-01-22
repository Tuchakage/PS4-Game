using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform[] checkpoint1RespawnPoint;
    public Transform[] checkpoint2RespawnPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with "+ other.name);

        //Check which Checkpoint the Player is at
        if (other.gameObject.CompareTag("Player 1")) 
        {
            PlayerMovement pm = GameObject.Find("Player").GetComponent<PlayerMovement>();
            int checkpoint = pm.checkpoints;
            RespawnAtCheckPoint(checkpoint, other);
        }
        else if (other.gameObject.CompareTag("Player 2"))
        {
            PlayerMovement pm = GameObject.Find("Player 2").GetComponent<PlayerMovement>();
            //Check which checkpoint the player is at
            int checkpoint = pm.checkpoints;
            RespawnAtCheckPoint(checkpoint, other);
            other.GetComponent<Owner>().owner.GetComponent<Lives>().LoseALife();
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

    public void RespawnAtCheckPoint(int checkpoint, Collider other)  
    {
        if (checkpoint == 1)
        {
            if (other.gameObject.CompareTag("Player 1"))
            {
                Debug.Log("Found");
                other.transform.position = checkpoint1RespawnPoint[0].position;
                other.transform.rotation = new Quaternion(0, 0, 0, 1);
                //print("BOZO");
            }
            else if (other.gameObject.CompareTag("Player 2"))
            {
                other.transform.position = checkpoint1RespawnPoint[1].position;
                other.transform.rotation = new Quaternion(0, 0, 0, 1);
            }
        }
        else if (checkpoint == 2)
        {
            if (other.gameObject.CompareTag("Player 1"))
            {
                Debug.Log("Found");
                other.transform.position = checkpoint2RespawnPoint[0].position;
                other.transform.rotation = new Quaternion(0, 0, 0, 1);
                //print("BOZO");
            }
            else if (other.gameObject.CompareTag("Player 2"))
            {
                other.transform.position = checkpoint2RespawnPoint[0].position;
                other.transform.rotation = new Quaternion(0, 0, 0, 1);
            }
        }
    }
}
