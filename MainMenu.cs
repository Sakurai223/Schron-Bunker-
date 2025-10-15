using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettings()
    {
        Debug.Log("Show setting");
        
    }

    public void ShowAbout()
    {
        Debug.Log("Show info about game");
       
    }

    public void QuitGame()
    {
        Debug.Log("Leave Game");
        Application.Quit();
    }
}
