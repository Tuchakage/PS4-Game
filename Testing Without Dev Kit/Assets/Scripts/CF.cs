using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CF : MonoBehaviour
{
	
		public Transform player;
		[SerializeField] Vector3 offset;
		[Range(0.01f, 1.0f)]
		public float SmoothFactor = 0.5f;
		// Use this for initialization
		void Start()
		{
		}
		// Update is called once per frame
		void Update()
		{
			//This get the camera to follow the player from the player's position and the camera's transform.position
			Vector3 newPos = player.position + offset;
			transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
		}
	
}