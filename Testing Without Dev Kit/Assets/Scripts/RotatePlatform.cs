using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public float rotationSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player 1"))
        {
            other.transform.parent = transform.parent;
        }
    }
}
