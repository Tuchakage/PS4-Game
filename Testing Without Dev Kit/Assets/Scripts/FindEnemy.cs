using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            //If the trigger touches an enemy tell the owner of this trigger (Most likely Player 1) to set it as Enemy target so the player can attack it
            PlayerMovement pm = this.gameObject.GetComponent<Owner>().owner.GetComponent<PlayerMovement>();
            pm.enemyTarget = col.gameObject.transform;

        }
    }
}
