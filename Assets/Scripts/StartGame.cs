using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Levels/Level1");
    }
}
