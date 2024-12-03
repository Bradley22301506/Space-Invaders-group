using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of the main enemy ship
        initialPosition = transform.position;
    }

    public void ResetShipPosition()
    {
        // Reset the entire ship (parent) back to its initial position
        transform.position = initialPosition;
    }
}

