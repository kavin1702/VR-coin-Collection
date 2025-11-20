using UnityEngine;

public class EndZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player Entered the zone !!");
            GameManager.Instance.GameOver();
        }
    }
}
