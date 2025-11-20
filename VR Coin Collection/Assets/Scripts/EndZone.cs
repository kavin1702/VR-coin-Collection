
//using UnityEngine;

//public class EndZoneManager : MonoBehaviour
//{
//    public GameObject gameOverpanel;

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            TriggerEndGame();
//        }
//    }

//    void TriggerEndGame()
//    {
//        // Show game over UI
//        gameOverpanel.SetActive(true);

//        // Destroy all balls
//        Ball[] balls = FindObjectsOfType<Ball>();
//        foreach (Ball b in balls)
//        {
//            Destroy(b.gameObject);
//        }

//        // Pause the game
//        Time.timeScale = 0f;
//    }
//}
using UnityEngine;

public class EndZoneManager : MonoBehaviour
{
    public GameObject gameOverpanel;
    public AudioSource audioSource;
    public AudioSource audioSourceBg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSourceBg.Stop();
            audioSource.Play();
            TriggerEndGame();
        }
    }

    void TriggerEndGame()
    {
        // Destroy all balls
        Ball[] balls = FindObjectsOfType<Ball>();
        foreach (Ball b in balls)
        {
            Destroy(b.gameObject);
        }

        // Call GameManager to update final UI
        GameManager.Instance.GameOver();

        // Enable the game over panel (GameManager also handles this)
        gameOverpanel.SetActive(true);
    }
}
