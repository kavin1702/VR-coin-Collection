using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [Header("Score")]
    public int score = 0;
    public int positiveCount = 0;

    [Header("UI")]
    public TMP_Text scoreText;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip positiveSFX;
    public AudioClip negativeSFX;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddPositiveScore()
    {
        score += 1;
        positiveCount += 1;
        PlaySFX(positiveSFX);
        UpdateUI();
    }

    public void AddNegativeScore()
    {
        score -= 1;
        PlaySFX(negativeSFX);
        UpdateUI();
    }

    private void PlaySFX(AudioClip clip)
    {
        if (clip != null)
            audioSource.PlayOneShot(clip);
    }

    private void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
