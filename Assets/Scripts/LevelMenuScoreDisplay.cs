using UnityEngine;
using UnityEngine.UI;

public class LevelMenuScoreDisplay : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private void Start()
    {
        int currentScore = PlayerPrefs.GetInt("Score", 0); // skor kaydedilmi�se al, yoksa 0
        scoreText.text = "Score: " + currentScore.ToString();
    }
}
