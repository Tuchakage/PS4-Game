using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCheckpoints : MonoBehaviour
{
    // Start is called before the first frame update
    public int checkpoint;


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player 1")
        {
            GameObject player1;
            player1 = GameObject.Find("Player");
            player1.gameObject.GetComponent<PlayerMovement>().checkpoints = checkpoint;
        }
        else if (col.gameObject.tag == "Player 2")
        {
            GameObject player2;
            player2 = GameObject.Find("Player 2");
            player2.gameObject.GetComponent<PlayerMovement>().checkpoints = checkpoint;
        }
    }

}
