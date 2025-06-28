using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private float timeLimit = 60f; // saniye
    [SerializeField] private Text timerText;

    private float timer;
    private bool isTimeUp = false;

    private void Start()
    {
        timer = timeLimit;
    }

    private void Update()
    {
        if (isTimeUp) return;

        timer -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.CeilToInt(timer).ToString();

        if (timer <= 0f)
        {
            isTimeUp = true;
            timerText.text = "Time: 0";
            TimeUp();
        }
    }

    private void TimeUp()
    {
        UIManager ui = FindFirstObjectByType<UIManager>();
        if (ui != null)
            ui.GameOver();
    }
}
