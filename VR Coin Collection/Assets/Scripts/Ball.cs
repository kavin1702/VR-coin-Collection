using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3f;
    public int value = 1;    // +1 = positive ball,  -1 = negative ball

    void Update()
    {
        // Move from +Z to -Z
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Auto destroy if goes far behind player
        if (transform.position.z < -20f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Weapon hits the ball → update score + destroy
        if (other.CompareTag("Weapon"))
        {
            ScoreManager.Instance.AddScore(value);
            Destroy(gameObject);
        }
    }
}
