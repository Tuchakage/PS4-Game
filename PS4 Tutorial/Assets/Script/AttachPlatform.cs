using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlatform : MonoBehaviour
{
    List<GameObject> player;

    private void Start()
    {
        player = new List<GameObject>();
    }
    private void Update()
    {
        foreach (GameObject g in player) 
        {
            //Make sure the Rotation doesnt change
            g.transform.rotation = new Quaternion(0f, 0f, 0f, 1f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided With: " + other.gameObject.name);
        if (other.gameObject.tag == "Player 1" || other.gameObject.tag == "Player 2") 
        {
            //Add the Player to the list so that we can make sure the Rotation doesnt change
            player.Add(other.gameObject);
            //Attach player to PLatform
            other.transform.parent = transform;
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        //Makes sure the sphere doesnt become deformed
        other.transform.localScale = new Vector3(0.0811907947f, 1.66255343f, 0.0811907947f);
    }

    private void OnTriggerExit(Collider other)
    {
        //Remove from list
        player.Remove(other.gameObject);
        //Detach Player from Platform
        other.transform.parent = null;
        //Make sure its set the the scale before it entered the trigger
        other.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);

    }
}
