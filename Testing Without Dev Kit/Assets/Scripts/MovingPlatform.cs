using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public List<Transform> _waypoints;
    public float _moveSpeed;
    public int _target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_target].position, _moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (transform.position == _waypoints[_target].position)
        {
            if (_target == _waypoints.Count - 1)
            {
                _target = 0;
            }
            else
            {
                _target += 1;
            }
        }
    }
    
    //Dunno if this is working
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player 1") || other.gameObject.CompareTag("Player 2") || other.gameObject.CompareTag("Player 3") || other.gameObject.CompareTag("Player 4"))
        {
            transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player 1") || other.gameObject.CompareTag("Player 2") || other.gameObject.CompareTag("Player 3") || other.gameObject.CompareTag("Player 4"))
        {
            transform.parent = null;
        }
    }
}
