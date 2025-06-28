using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneButtons : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("_MainMenu");
    }
}
