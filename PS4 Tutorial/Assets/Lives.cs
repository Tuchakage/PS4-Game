using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lives : MonoBehaviour
{
    public int lives;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (lives <= 0) 
        {
            SceneManager.LoadScene(3);
        }
    }

    public void LoseALife() 
    {
        lives--;
    }
}
