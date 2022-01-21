using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    public Rigidbody playerRb;

    float destroyDelay = 1.5f;

    public PlayerMovement playerMovement;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player 1")
        {
            //Get the owner of the Rigidbody
            GameObject player = playerRb.GetComponent<Owner>().owner;
            PlayerMovement pm = player.GetComponent<PlayerMovement>();

            //Makes sure the Player cannot detect this enemy again
            pm.enemyTarget = null;
            playerRb = collision.collider.GetComponent<Rigidbody>();
            // Moves the enemy cube back when player collides with it.
            float newEnemyPos = transform.position.z + 5f;
            //Shoot The Enemy Diagonally
            GetComponent<Rigidbody>().AddForce(transform.up * 500);
            GetComponent<Rigidbody>().AddForce(transform.forward * -500);
            transform.position = new Vector3(transform.position.x, transform.position.y, newEnemyPos);

            playerRb.velocity = new Vector3(0, 0, 0);
            

            // Destroy cube after a set amount of time.
            Destroy(gameObject, destroyDelay);

            //Shoot the Player upwards
            //playerRb.AddForce(playerRb.gameObject.transform.up * -1, ForceMode.Impulse);
            //playerRb.AddForce(playerRb.gameObject.transform.forward * -1, ForceMode.Impulse);
            // Set player velocity to 0 when it collides with cube.
        }
        //if (collision.gameObject.tag == "Player 2")
        //{
        //    float newEnemyPos = transform.position.z + 5f;
        //}
        //if (collision.gameObject.tag == "Player 3")
        //{
        //    float newEnemyPos = transform.position.z + 5f;
        //}
        //if (collision.gameObject.tag == "Player 4")
        //{
        //    float newEnemyPos = transform.position.z + 5f;
        //}
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1")
        {
            //playerRb.velocity = playerMovement.forwardAccel;
        }
    }
}
