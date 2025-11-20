using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
