
using UnityEngine;

public class EndZoneManager : MonoBehaviour
{
    public GameObject gameOverpanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TriggerEndGame();
        }
    }

    void TriggerEndGame()
    {
        // Show game over UI
        gameOverpanel.SetActive(true);

        // Destroy all balls
        Ball[] balls = FindObjectsOfType<Ball>();
        foreach (Ball b in balls)
        {
            Destroy(b.gameObject);
        }

        // Pause the game
        Time.timeScale = 0f;
    }
}
