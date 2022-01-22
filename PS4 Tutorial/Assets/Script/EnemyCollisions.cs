using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    Animator eanim;
    public Rigidbody playerRb;

    float destroyDelay = 1.5f;

    public PlayerMovement playerMovement;

    private void Start()
    {
        eanim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player 2")
        {
            //Get the owner of the Rigidbody
            GameObject player = playerRb.GetComponent<Owner>().owner;
            PlayerMovement pm = player.GetComponent<PlayerMovement>();

            if (pm.launched) //If the player is doing a homing attack
            {
                //Makes sure the Player cannot detect this enemy again
                pm.enemyTarget = null;
                playerRb = col.collider.GetComponent<Rigidbody>();
                // Moves the enemy cube back when player collides with it.
                Vector3 direction = (transform.position - col.transform.position).normalized;
                //Shoot The Enemy Diagonally
                GetComponent<Rigidbody>().AddForce(Vector3.up * 1000, ForceMode.Impulse);
                GetComponent<Rigidbody>().AddForce(-direction * 5000, ForceMode.Impulse);
                

                //Shoot the Player backwards
                playerRb.AddForce(Vector3.up * 2000, ForceMode.Impulse);
                playerRb.AddForce(-Vector3.forward * 500, ForceMode.Impulse);
                playerRb.velocity = new Vector3(0, playerRb.gameObject.transform.up.y, 0);
                // Destroy cube after a set amount of time.
                Destroy(gameObject, destroyDelay);


            }
            else //If the player is not using a homing attack
            {
                eanim.SetTrigger("Attack");
                //Push Player backwards
                playerRb.AddForce(Vector3.up * 1500, ForceMode.Impulse);
                playerRb.AddForce(-Vector3.forward * 1500, ForceMode.Impulse);
            }



        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1")
        {
            //playerRb.velocity = playerMovement.forwardAccel;
        }
    }
}
