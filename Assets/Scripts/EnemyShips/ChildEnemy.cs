using UnityEngine;
public class ChildEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            
            EnemyShip parentShip = GetComponentInParent<EnemyShip>();
            
            if (parentShip != null)
            {
                parentShip.ResetShipPosition();
            }

        }
    }
}
