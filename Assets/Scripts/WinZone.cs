using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    [SerializeField] private string winSceneName = "WinScene";
    [SerializeField] private GameObject winPanel;
    [SerializeField] private float delayBeforeScene = 2f;

    private bool hasWon = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasWon) return;

        if (collision.CompareTag("Player"))
        {
            hasWon = true;
            winPanel.SetActive(true); // WIN yazýsýný göster
            Invoke(nameof(LoadNextScene), delayBeforeScene);
        }
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene(winSceneName);
    }
}

