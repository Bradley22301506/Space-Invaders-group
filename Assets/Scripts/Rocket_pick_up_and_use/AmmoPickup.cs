using UnityEngine;

public class AmmoPickup : MonoBehaviour

{
    [Header("Ammo Settings")]
    [SerializeField] private int ammoAmount = 1;
    
    [Header("Visual Effect")]
    [SerializeField] private float bobHeight = 0.2f;
    [SerializeField] private float bobSpeed = 1f;



    private Vector3 startPosition;
    private float timeOffset;

    void Start()
    {
        startPosition = transform.position;
        timeOffset = Random.Range(0f,Mathf.PI * 2);

    }

    void Update()
    {
        float newY = startPosition.y + (Mathf.Sin((Time.time + timeOffset) * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            RocketShooting rocketShooting = other.GetComponent<RocketShooting>();

            if (rocketShooting != null)
            {
               rocketShooting.AddAmmo(ammoAmount);
               Destroy(gameObject);
            
            }
        }
    }
}