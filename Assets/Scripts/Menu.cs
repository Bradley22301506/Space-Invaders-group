using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu : MonoBehaviour
{
   public void PlayGame()
   {
    SceneManager.LoadSceneAsync("SampleScene");
   }
   public void QuitGame()
   {
   Application.Quit();
   }
}