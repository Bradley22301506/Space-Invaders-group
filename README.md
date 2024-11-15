So I have created a simple rocket character Using AI, to create the rocket and Implimented a simple left and right movement system, it appears to be working well so far. 



public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5;
    public float hInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    hInput = Input.GetAxisRaw("Horizontal");


        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime); 
        
    }
}

so in this code I created two variables, one called "moveSpeed" and the other called "Hinput"; move speed allows us to adjust the player's speed when needed; the "hInput" is the
variable for the movement, I have used the "Horizontal" method which is embedded in Unity for us to create movement, it is just a simple transform system on the Vector2 as it is a 2D
game.
