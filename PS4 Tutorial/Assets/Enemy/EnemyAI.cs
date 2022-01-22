using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    Transform player;
    NavMeshAgent eAgent;
    Animator eanim;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player 2").transform;
        eAgent = GetComponent<NavMeshAgent>();
        eanim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distFromPlayer = Vector3.Distance(transform.position, player.position);
        if (distFromPlayer < 15) //If Player is in Range Move Towards Player
        {
            eAgent.isStopped = false;
            eAgent.SetDestination(player.position);
            eanim.SetBool("isRunning", true);
        }
        else //Enemy not in distance
        {
            eAgent.isStopped = true;
            eanim.SetBool("isRunning", false);
        }
    }
}
