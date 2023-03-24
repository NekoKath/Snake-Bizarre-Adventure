using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void NextLevelPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
