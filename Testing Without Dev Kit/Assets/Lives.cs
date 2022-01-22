using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0) 
        {
            Debug.Log("Runner Has Lost");
        }
    }

    public void LoseALife() 
    {
        lives--;
    }
}
