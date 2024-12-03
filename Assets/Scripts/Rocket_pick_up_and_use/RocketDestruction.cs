using UnityEngine;


public class RocketDestruction : MonoBehaviour
{

    public float moveSpeed;
    private int enemiesHit = 0;
    public int maxEnemies = 2;
    

    private PointManager pointManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

      private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            enemiesHit++;
            Destroy(collision.gameObject);
            pointManager.UpdateScore(30);
            
            if (enemiesHit >= maxEnemies)
            {
                Destroy(gameObject);
            }
            
        }
        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
