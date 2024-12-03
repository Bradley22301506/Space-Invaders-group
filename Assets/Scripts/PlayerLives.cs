using UnityEngine;
using UnityEngine.SceneManagement; // To restart the game or load a game-over scene
using UnityEngine.UI;


public class PlayerLives : MonoBehaviour
{ 
    public int lives = 3;
    public Image[] livesUI;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            lives -= 1;

            for(int i = 0; i < livesUI.Length; i++)
            {
                if(i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadSceneAsync("Menu");
            }
        }
    }
}