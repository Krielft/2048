using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public string levelToLoad;

    public void RePlay()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("HUD");
    }
}
