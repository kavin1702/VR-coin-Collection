//using UnityEngine;
//using TMPro;

//public class ScoreManager : MonoBehaviour
//{
//    public static ScoreManager Instance;

//    public int score = 0;          // total score
//    public int positiveCount = 0;  // number of positive balls hit

//    [Header("UI")]
//    public TextMeshProUGUI scoreText;

//    private void Awake()
//    {
//        Instance = this;
//    }

//    private void Start()
//    {
//        UpdateScoreUI();
//    }

//    public void AddScore(int value)
//    {
//        score += value;

//        if (value > 0)
//            positiveCount++;

//        UpdateScoreUI();
//    }

//    void UpdateScoreUI()
//    {
//        if (scoreText != null)
//            scoreText.text = "Score: " + score;
//    }
//}

using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;
    public int positiveCount = 0;

    [Header("UI - Main HUD")]
    public TextMeshProUGUI scoreText;

    [Header("UI - Controller HUD")]
    public TextMeshProUGUI controllerScoreText;   // NEW reference

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int value)
    {
        score += value;

        if (value > 0)
            positiveCount++;

        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        // Main screen UI
        if (scoreText != null)
            scoreText.text = "Score: " + score;

        // Controller floating UI
        if (controllerScoreText != null)
            controllerScoreText.text = score.ToString();
    }
}
