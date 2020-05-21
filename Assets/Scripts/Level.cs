using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
   
    public void LoadGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void PlayAgain()
    {
       
        SceneManager.LoadScene(1);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        Application.Quit();
    }



}
