using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    /*public Rigidbody playerRb;

    float destroyDelay = 1.5f;

    public PlayerMovement playerMovement;*/


    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player 1")
        {
            // Moves the enemy cube back when player collides with it.
            float newEnemyPos = transform.position.z + 5f;
            transform.position = new Vector3(transform.position.x, transform.position.y, newEnemyPos);

            // Set player velocity to 0 when it collides with cube.
            playerRb.velocity = new Vector3(0, 0, 0);

            // Destroy cube after a set amount of time.
            Destroy(gameObject, destroyDelay);
        }
        if (collision.gameObject.tag == "Player 2")
        {
            float newEnemyPos = transform.position.z + 5f;
        }
        if (collision.gameObject.tag == "Player 3")
        {
            float newEnemyPos = transform.position.z + 5f;
        }
        if (collision.gameObject.tag == "Player 4")
        {
            float newEnemyPos = transform.position.z + 5f;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1")
        {
            playerRb.velocity = playerMovement.forwardAccel;
        }
    }*/
}
