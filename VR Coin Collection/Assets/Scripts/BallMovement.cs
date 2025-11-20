using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move from +Z → -Z
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
