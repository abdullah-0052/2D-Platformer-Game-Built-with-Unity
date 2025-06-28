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

    // Hen�z aktif olmayan seviye
    public void LoadLevel3()
    {
        Debug.Log("Level 3 hen�z aktif de�il.");
    }

    // Ana Men�'ye geri d�n
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("_MainMenu");
    }
    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("PlayerScore");
    }
}
