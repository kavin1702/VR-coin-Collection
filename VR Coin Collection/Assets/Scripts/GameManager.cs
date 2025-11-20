using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverPanel;

    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI positiveBallText;

    private void Awake()
    {
        Instance = this;
    }

    public void GameOver()
    {
        Time.timeScale = 0f; // pause game

        gameOverPanel.SetActive(true);

        finalScoreText.text = "Final Score: " + ScoreManager.Instance.score;
        positiveBallText.text = "Positive Balls Caught: " + ScoreManager.Instance.positiveCount;
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
