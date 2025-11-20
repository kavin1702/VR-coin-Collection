using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Transform spawnPointA;
    public Transform spawnPointB;

    public GameObject positiveBall;
    public GameObject negativeBall;

    public float spawnInterval = 1.5f;
    private bool spawnAtA = true;

    void Start()
    {
        InvokeRepeating(nameof(SpawnBall), 1f, spawnInterval);
    }

    void SpawnBall()
    {
        // Choose positive or negative ball randomly
        GameObject prefab = Random.Range(0, 2) == 0 ? positiveBall : negativeBall;

        // Alternate between A and B
        Transform point = spawnAtA ? spawnPointA : spawnPointB;

        Instantiate(prefab, point.position, point.rotation);

        spawnAtA = !spawnAtA; // switch spawn point
    }
}
 