using UnityEngine;

public class RocketShooting : MonoBehaviour
{
    [Header("Rocket Settings")]

    [SerializeField] private GameObject RocketPrefab;
    [SerializeField] private Transform firepoint;
    [SerializeField] private float rocketSpeed = 10f;


    [Header("Rocket Ammo")]

    [SerializeField] private int maxRockets = 1;
    [SerializeField] private bool startWithRocket = false;

    private float nextFireTime;
    private int currentAmmo;

     void Start()
     {
        currentAmmo = startWithRocket ? maxRockets : 0;
     }

     void Update()
     {
         if (Input.GetKeyDown(KeyCode.Space) && CanShoot() && currentAmmo > 0)
        {
            Shoot();
        }

     }

     private bool CanShoot()
     {
        return Time.time >= nextFireTime && currentAmmo > 0;
     }


     private void Shoot()
     {
        GameObject Rocket = Instantiate(RocketPrefab, firepoint.position, firepoint.rotation);

        Rigidbody2D rb = Rocket.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.up * rocketSpeed;
        }
        
        currentAmmo--;
     }



     public void AddAmmo(int amount)
     {
        currentAmmo = Mathf.Min(currentAmmo + amount, maxRockets);
     }
}