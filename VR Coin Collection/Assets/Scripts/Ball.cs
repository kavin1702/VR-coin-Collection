using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isPositive;  // set in inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            if (isPositive)
                ScoreManager.Instance.AddPositiveScore();
            else
                ScoreManager.Instance.AddNegativeScore();

            Destroy(gameObject);
        }
    }
}
