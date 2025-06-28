using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsSceneButton : MonoBehaviour
{
    // Level sahnelerine git
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
            SceneManager.LoadScene("Level2");
    }

    // Henüz aktif olmayan seviye
    public void LoadLevel3()
    {
        Debug.Log("Level 3 henüz aktif deðil.");
    }

    // Ana Menü'ye geri dön
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("_MainMenu");
    }
    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("PlayerScore");
    }
}
