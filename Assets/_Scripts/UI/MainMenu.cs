using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Loading");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void OpenTutorial()
    {
        Debug.Log("Tutorial");
    }

    public void OpenSettings()
    {
        Debug.Log("Settings");
    }
}
